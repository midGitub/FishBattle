﻿using System;
using System.Collections.Generic;

namespace Fish
{
    //单个或组合的战斗动画
    public interface IBattlePlayCtl
    {
        void Play();
        //Pause,Resume,Reset,Reverse 等方法方便调试，暂不实现
        /*
        void Puase();
        void Resume();
        void Reset();
        void Reverse();
        */

        //取消执行并还原到初始状态，返回当前执行已知错误
        IPlayFinishedState Cancel();
        
        //释放内部所有引用，例如OnEnd事件关联的Delegates
        void Dispose();

        //动画结束后的事件，每个实现必须保证时间到了一定触发，除非被暂停，重置，或者释放
        event Action<IPlayFinishedState> OnEnd;

        //这个战斗动画的总时长，单位秒，后面所有时间单位都是秒
        float Duaration();

        //当前播放的进度
        float CurrentProgress();

        BattlePlayingState CurrentState { get; }
    }

    //实现类除了PlayErrState，还可以提供更多信息，例如提供Exception是什么，或者多个异常是什么，或者异常的时间点等
    public interface IPlayFinishedState
    {
        PlayErrState LastError();
    }

    public enum PlayErrState
    {
        NotStarted,
        NotFinished,
        Success,
        Timeout,
        ///出错但是完成了！
        Exception,
    }

    public enum BattlePlayingState
    {
        Pause,
        Started,
        Dispose,
    }

    public static class BattlePlayCtlExt
    {
        public static IBattlePlayCtl Chain(this IBattlePlayCtl first, IBattlePlayCtl second)
        {
            if (first == null) return second;
            if (second == null) return first;
            return new SeqCompositePlayCtl(new[] {first, second});
        }
    }

    /// 基类需要提供计时操作，底层框架对计时器进行优化。
    /// 实现不依赖具体动画，而是根据时间来计算，保证OnEnd一定能够被调用，并收集结束时的各种错误。
    public abstract class BattlePlayCtlBasic : IBattlePlayCtl
    {
        private float _elapseTime;

        private BattlePlayingState _playState;

        protected MonsterController _mc;
        //TODO invoke by timer
        void Update()
        {
            if (_playState != BattlePlayingState.Started) return;
            //TODO update _elapseTime

            if (_elapseTime > Duaration())
            {
                var playFinishedState = GenFinishedState();
                //TODO debug log playFinishedState
                CallOnEnd(playFinishedState);
            }
        }

        protected void CallOnEnd(IPlayFinishedState playFinishedState)
        {
            GameUtil.SafeRun(OnEnd, playFinishedState);
            
            _playState = BattlePlayingState.Pause;
        }

        private void StartTimer()
        {
            //TODO might need to tell timer to start
        }

        protected bool IsStarted()
        {
            return _playState == BattlePlayingState.Started;
        }

        public event Action<IPlayFinishedState> OnEnd;

        public BattlePlayingState CurrentState
        {
           get { return _playState; }
        }
        
        public float CurrentProgress()
        {
            return _elapseTime;
        }

        public IPlayFinishedState Cancel()
        {
            if (_playState == BattlePlayingState.Dispose) return null;
            _elapseTime = 0;
            _playState = BattlePlayingState.Pause;
            var playFinishedState = CustomCancel();
            return playFinishedState;
        }

        protected virtual IPlayFinishedState CustomCancel()
        {
            return null;
        }

        public void Dispose()
        {
            if (_playState == BattlePlayingState.Dispose) return;
            
            CustomDispose();
            OnEnd = null;
            _playState = BattlePlayingState.Dispose;
        }

        public void Play()
        {
            if (_playState != BattlePlayingState.Pause) return;

            _playState = BattlePlayingState.Started;
            StartTimer();
            CustomStart();
        }

        protected virtual void CustomDispose()
        {
        }

        protected virtual void CustomStart()
        {
        }

        protected abstract IPlayFinishedState GenFinishedState();

        public abstract float Duaration();
    }

    //保持一段时间状态不变的动画
    public class KeepStatePlayCtl : BattlePlayCtlBasic
    {
        private readonly float _duration;

        public KeepStatePlayCtl(float duaration)
        {
            _duration = duaration;
        }

        protected override IPlayFinishedState GenFinishedState()
        {
            var started = IsStarted();
            var errCode = !started
                ? PlayErrState.NotStarted
                : CurrentProgress() < _duration
                    ? PlayErrState.NotFinished
                    : PlayErrState.Success;
            return new SimplePlayFinishedState(errCode);
        }

        public override float Duaration()
        {
            return _duration;
        }
    }

    public class SimplePlayFinishedState : IPlayFinishedState
    {
        private readonly PlayErrState _st;

        public SimplePlayFinishedState(PlayErrState st)
        {
            _st = st;
        }

        public PlayErrState LastError()
        {
            return _st;
        }
    }

    //顺序复合多个动画
    public class SeqCompositePlayCtl : BattlePlayCtlBasic
    {
        private IBattlePlayCtl[] _playCtlList;
        private readonly float _totalTime;
        private int _playIdx;
        private List<Tuple<int, IPlayFinishedState>> _abnormalList;

        public SeqCompositePlayCtl(IBattlePlayCtl[] lst)
        {
            _playCtlList = lst;
            for (var i = 0; i < _playCtlList.Length; i++)
            {
                var play = _playCtlList[i];
                _totalTime += play.Duaration();
            }
            _abnormalList = new List<Tuple<int, IPlayFinishedState>>();
        }
        
        //intensionally not check (playList != null),thow exception if null
        public SeqCompositePlayCtl(List<IBattlePlayCtl> playList):this(playList.ToArray())
        {
        }

        protected override IPlayFinishedState GenFinishedState()
        {
            var started = IsStarted();
            var errCode = !started
                ? PlayErrState.NotStarted
                : CurrentProgress() < _totalTime
                    ? PlayErrState.NotFinished
                    : !_abnormalList.IsNullOrEmpty()
                        ? PlayErrState.Exception
                        : _playIdx == _playCtlList.Length
                            ? PlayErrState.Success
                            : PlayErrState.Timeout;
            return new MultiPlayFinishedState(errCode, _abnormalList);
        }

        public override float Duaration()
        {
            return _totalTime;
        }

        protected override void CustomStart()
        {
            if (_playIdx < _playCtlList.Length)
            {
                var battlePlay = _playCtlList[_playIdx];
                battlePlay.OnEnd += NextPlay;
                battlePlay.Play();
            }
        }

        private void NextPlay(IPlayFinishedState lastPlayState)
        {
            if (lastPlayState != null)
            {
                var lastErrCode = lastPlayState.LastError();
                if (lastErrCode != PlayErrState.Success)
                {
                    _abnormalList.Add(Tuple.Create(_playIdx, lastPlayState));
                }
            }
            _playCtlList[_playIdx].OnEnd -= NextPlay;
            _playIdx++;
            if (_playIdx == _playCtlList.Length)
            {
                var errCode = _abnormalList.IsNullOrEmpty()
                    ? PlayErrState.Success
                    : PlayErrState.Exception;
                CallOnEnd(new MultiPlayFinishedState(errCode, _abnormalList));
                return;
            }
            CustomStart();
        }

        protected override void CustomDispose()
        {
            if (_playCtlList != null)
            {
                for (var i = 0; i < _playCtlList.Length; i++)
                {
                    _playCtlList[i].Dispose();
                }
            }
            
            _playCtlList = null;
            _abnormalList = null;
        }

        protected override IPlayFinishedState CustomCancel()
        {
            if (_playCtlList != null)
            {
                for (var i = 0; i < _playCtlList.Length; i++)
                {
                    _playCtlList[i].Cancel();
                }
            }
            var currentAb = _abnormalList;
            _abnormalList = null;
            _playIdx = 0;
            return currentAb.IsNullOrEmpty() ? null : new MultiPlayFinishedState(PlayErrState.Exception, _abnormalList);
        }
    }

    //多个动画复合的完成状态
    public class MultiPlayFinishedState : SimplePlayFinishedState
    {
        private readonly ICollection<Tuple<int, IPlayFinishedState>> _errLst;

        public MultiPlayFinishedState(PlayErrState st, ICollection<Tuple<int, IPlayFinishedState>> errLst) : base(st)
        {
            _errLst = errLst;
        }

        public ICollection<Tuple<int, IPlayFinishedState>> GetErrorList()
        {
            return _errLst;
        }
    }

    //并行复合多个动画
    public class ParallCompositePlayCtl : BattlePlayCtlBasic
    {
        private IBattlePlayCtl[] _playCtlList;
        private readonly float _totalTime;
        private List<Tuple<int, IPlayFinishedState>> _abnormalList;
        private PlayEnd _cb;

        public ParallCompositePlayCtl(IBattlePlayCtl[] playCtlList)
        {
            _playCtlList = playCtlList;
            for (var i = 0; i < _playCtlList.Length; i++)
            {
                var totalTime = _playCtlList[i].Duaration();
                if (_totalTime < totalTime)
                {
                    _totalTime = totalTime;
                }
            }
            _abnormalList = new List<Tuple<int, IPlayFinishedState>>();
        }
        
        public ParallCompositePlayCtl(List<IBattlePlayCtl> playList):this(playList.ToArray())
        {
        }

        protected override IPlayFinishedState GenFinishedState()
        {
            var started = IsStarted();
            var errCode = !started
                ? PlayErrState.NotStarted
                : CurrentProgress() < _totalTime
                    ? PlayErrState.NotFinished
                    : _abnormalList != null && _abnormalList.Count > 0
                        ? PlayErrState.Exception
                        : _cb != null && !_cb.IsAllFinish()
                            ? PlayErrState.Timeout
                            : PlayErrState.Success;
            return new MultiPlayFinishedState(errCode, _abnormalList);
        }

        public override float Duaration()
        {
            return _totalTime;
        }
        
        protected override IPlayFinishedState CustomCancel()
        {
            if (_playCtlList != null)
            {
                for (var i = 0; i < _playCtlList.Length; i++)
                {
                    _playCtlList[i].Cancel();
                }
            }
            var currentAb = _abnormalList;
            _abnormalList = null;
            _cb = null;
            return currentAb.IsNullOrEmpty() ? null : new MultiPlayFinishedState(PlayErrState.Exception, _abnormalList);
        }

        protected override void CustomDispose()
        {
            if (_playCtlList != null)
            {
                for (var i = 0; i < _playCtlList.Length; i++)
                {
                    _playCtlList[i].Dispose();
                }
            }
            _playCtlList = null;
            _abnormalList = null;
            _cb = null;
        }

        protected override void CustomStart()
        {
            _cb = new PlayEnd(_playCtlList.Length, this);
            for (var i = 0; i < _playCtlList.Length; i++)
            {
                var play = _playCtlList[i];
                play.OnEnd += _cb.EndOn(i);
                play.Play();
            }
        }

        private void SomePlayEnd(int index, IPlayFinishedState lastPlayState)
        {
            if (lastPlayState != null)
            {
                var lastErrCode = lastPlayState.LastError();
                if (lastErrCode != PlayErrState.Success)
                {
                    _abnormalList.Add(Tuple.Create(index, lastPlayState));
                }
            }
            _playCtlList[index].OnEnd -= _cb.EndOn(index);
            _cb.Remove(index);
            if (_cb.IsAllFinish())
            {
                var errCode = _abnormalList != null && _abnormalList.Count > 0
                    ? PlayErrState.Exception
                    : PlayErrState.Success;
                CallOnEnd(new MultiPlayFinishedState(errCode, _abnormalList));
                _cb = null;
            }
        }

        private class PlayEnd
        {
            private readonly List<Action<IPlayFinishedState>> _actLst;

            public PlayEnd(int count, ParallCompositePlayCtl ctx)
            {
                _actLst = new List<Action<IPlayFinishedState>>(count);
                for (var i = 0; i < _actLst.Count; i++)
                {
                    var index = i;
                    _actLst[i] = state => { ctx.SomePlayEnd(index, state); };
                }
            }

            public Action<IPlayFinishedState> EndOn(int index)
            {
                return _actLst[index];
            }

            public void Remove(int index)
            {
                _actLst[index] = null;
            }

            public bool IsAllFinish()
            {
                return _actLst.Find<Action<IPlayFinishedState>>(act=>act != null) != null;
            }
        }
    }

    //分支动画
    public class BranchCompositePlayCtl : BattlePlayCtlBasic
    {
        private IBattlePlayCtl _mainThread;
        private IBattlePlayCtl _branchThread;
        private IPlayFinishedState _branchError;
        private IPlayFinishedState _mainThreadErr;
        private bool _isFinished;

        public BranchCompositePlayCtl(IBattlePlayCtl mainThread, IBattlePlayCtl branchThread)
        {
            _mainThread = mainThread;
            _branchThread = branchThread;
        }

        protected override IPlayFinishedState GenFinishedState()
        {
            var started = IsStarted();
            var errCode = !started
                ? PlayErrState.NotStarted
                : CurrentProgress() < Duaration()
                    ? PlayErrState.NotFinished
                    : _branchError != null || _mainThreadErr != null
                        ? PlayErrState.Exception
                        : !_isFinished
                            ? PlayErrState.Timeout
                            : PlayErrState.Success;

            var abnormalList = CollectAbnormalList();

            return new MultiPlayFinishedState(errCode, abnormalList);
        }

        private Tuple<int, IPlayFinishedState>[] CollectAbnormalList()
        {
            if (_mainThreadErr == null && _branchError == null) return null;
            if (_mainThreadErr != null && _branchError != null)
                return new[] {Tuple.Create(0, _mainThreadErr), Tuple.Create(1, _branchError)};
            return _mainThreadErr != null
                ? new[] {Tuple.Create(0, _mainThreadErr)}
                : new[] {Tuple.Create(1, _branchError)};
        }

        public override float Duaration()
        {
            return _mainThread.Duaration();
        }

        protected override IPlayFinishedState CustomCancel()
        {
            _mainThread.Cancel();
            _branchThread.Cancel();
            _isFinished = false;
            var ablst = CollectAbnormalList();
            return ablst == null ? null : new MultiPlayFinishedState(PlayErrState.Exception, ablst);
        }

        protected override void CustomDispose()
        {
            _mainThread.Dispose();
            _branchThread.Dispose();
            _mainThread = null;
            _branchThread = null;
            _mainThreadErr = null;
            _branchError = null;
        }

        protected override void CustomStart()
        {
            _mainThread.Play();
            _mainThread.OnEnd += MainEnd;
            _branchThread.Play();
            _branchThread.OnEnd += BranchEnd;
        }

        private void BranchEnd(IPlayFinishedState obj)
        {
            _branchThread.OnEnd -= BranchEnd;
            if (obj != null)
            {
                if (obj.LastError() != PlayErrState.Success)
                {
                    _branchError = obj;
                }
            }
        }

        private void MainEnd(IPlayFinishedState obj)
        {
            _mainThread.OnEnd -= MainEnd;
            var mainErr = false;
            if (obj != null)
            {
                if (obj.LastError() != PlayErrState.Success)
                {
                    mainErr = true;
                    _mainThreadErr = obj;
                }
            }
            _isFinished = true;
            if (_branchError == null)
                CallOnEnd(obj);
            else
            {
                var playErrState = obj!=null ? obj.LastError() : PlayErrState.Success;
                var abnormalList = mainErr ? new []{Tuple.Create(0,obj),Tuple.Create(1,_branchError)} : new []{Tuple.Create(1,_branchError)};
                CallOnEnd(new MultiPlayFinishedState(playErrState, abnormalList));
            }
        }
    }
}