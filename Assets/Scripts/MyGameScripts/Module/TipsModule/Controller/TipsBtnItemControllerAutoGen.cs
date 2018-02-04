﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  TipsBtnItemController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface ITipsBtnItemController
{
    UniRx.IObservable<Unit> OnBtn_UIButtonClick { get; }
}

public partial class TipsBtnItemController:MonolessViewController<TipsBtnItem>, ITipsBtnItemController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        Btn_UIButtonEvt = View.btn.AsObservable();
    }

    protected override void ClearReactiveEvents(){
        Btn_UIButtonEvt = Btn_UIButtonEvt.CloseOnceNull();
    }

    private Subject<Unit> Btn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnBtn_UIButtonClick
    {
        get { return Btn_UIButtonEvt; }
    }
}