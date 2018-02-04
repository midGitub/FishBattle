﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  QuartzForgeItemController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IQuartzForgeItemController
{
     UniRx.IObservable<Unit> OnQuartzForgeItem_UIButtonClick{get;}

}

public partial class QuartzForgeItemController:MonolessViewController<QuartzForgeItem>, IQuartzForgeItemController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        QuartzForgeItem_UIButtonEvt = View.QuartzForgeItem_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        QuartzForgeItem_UIButtonEvt = QuartzForgeItem_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> QuartzForgeItem_UIButtonEvt;
    public UniRx.IObservable<Unit> OnQuartzForgeItem_UIButtonClick{
        get {return QuartzForgeItem_UIButtonEvt;}
    }


}