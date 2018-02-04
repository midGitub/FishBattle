﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  AssistForceUpgradeViewController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IAssistForceUpgradeViewController
{
     UniRx.IObservable<Unit> OnForgetBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnTipBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnUngradeBtn_UIButtonClick{get;}
     UniRx.IObservable<Unit> OnUpgradeTimesBtn_UIButtonClick{get;}

}

public partial class AssistForceUpgradeViewController:MonolessViewController<AssistForceUpgradeView>, IAssistForceUpgradeViewController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        ForgetBtn_UIButtonEvt = View.ForgetBtn_UIButton.AsObservable();
        TipBtn_UIButtonEvt = View.TipBtn_UIButton.AsObservable();
        UngradeBtn_UIButtonEvt = View.UngradeBtn_UIButton.AsObservable();
        UpgradeTimesBtn_UIButtonEvt = View.UpgradeTimesBtn_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        ForgetBtn_UIButtonEvt = ForgetBtn_UIButtonEvt.CloseOnceNull();
        TipBtn_UIButtonEvt = TipBtn_UIButtonEvt.CloseOnceNull();
        UngradeBtn_UIButtonEvt = UngradeBtn_UIButtonEvt.CloseOnceNull();
        UpgradeTimesBtn_UIButtonEvt = UpgradeTimesBtn_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> ForgetBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnForgetBtn_UIButtonClick{
        get {return ForgetBtn_UIButtonEvt;}
    }

    private Subject<Unit> TipBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnTipBtn_UIButtonClick{
        get {return TipBtn_UIButtonEvt;}
    }

    private Subject<Unit> UngradeBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnUngradeBtn_UIButtonClick{
        get {return UngradeBtn_UIButtonEvt;}
    }

    private Subject<Unit> UpgradeTimesBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnUpgradeTimesBtn_UIButtonClick{
        get {return UpgradeTimesBtn_UIButtonEvt;}
    }


}
