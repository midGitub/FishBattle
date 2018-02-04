﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  GMViewControllerAutoGen.cs
// this file is generate by tool
// **********************************************************************

using System;
using UniRx;

public partial interface IGMViewController:ICloseView
{
    UniRx.IObservable<Unit> OnCloseBtn_UIButtonClick { get; }
}

public partial class GMViewController:FRPBaseController<
    GMViewController
    , GMView
    , IGMViewController
    , IGMData>
    , IGMViewController
    {
	    //机器自动生成的事件订阅
        protected override void RegistEvent()
        {
            CloseBtn_UIButtonEvt = View.CloseBtn_UIButton.AsObservable();

        }

        protected override void RemoveEvent()
        {
            CloseBtn_UIButtonEvt = CloseBtn_UIButtonEvt.CloseOnceNull();

        }

        private Subject<Unit> CloseBtn_UIButtonEvt;
        public UniRx.IObservable<Unit> OnCloseBtn_UIButtonClick
        {
            get { return CloseBtn_UIButtonEvt; }
        }


}
