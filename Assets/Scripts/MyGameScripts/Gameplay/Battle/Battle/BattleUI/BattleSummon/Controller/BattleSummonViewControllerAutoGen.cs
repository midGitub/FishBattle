﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  BattleSummonViewController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IBattleSummonViewController
{
     UniRx.IObservable<Unit> OnSummonButton_UIButtonClick{get;}

}

public partial class BattleSummonViewController:MonolessViewController<BattleSummonView>, IBattleSummonViewController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        SummonButton_UIButtonEvt = View.SummonButton_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        SummonButton_UIButtonEvt = SummonButton_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> SummonButton_UIButtonEvt;
    public UniRx.IObservable<Unit> OnSummonButton_UIButtonClick{
        get {return SummonButton_UIButtonEvt;}
    }


}
