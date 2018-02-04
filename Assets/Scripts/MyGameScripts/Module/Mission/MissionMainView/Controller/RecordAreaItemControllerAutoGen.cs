﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  RecordAreaItemController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IRecordAreaItemController
{
     UniRx.IObservable<Unit> OnRecordAreaItem_UIButtonClick{get;}

}

public partial class RecordAreaItemController:MonolessViewController<RecordAreaItem>, IRecordAreaItemController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        RecordAreaItem_UIButtonEvt = View.RecordAreaItem_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        RecordAreaItem_UIButtonEvt = RecordAreaItem_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> RecordAreaItem_UIButtonEvt;
    public UniRx.IObservable<Unit> OnRecordAreaItem_UIButtonClick{
        get {return RecordAreaItem_UIButtonEvt;}
    }


}