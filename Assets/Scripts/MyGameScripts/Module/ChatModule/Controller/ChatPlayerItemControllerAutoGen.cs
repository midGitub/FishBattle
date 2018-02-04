﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  ChatPlayerItemController.cs
// the file is generated by tools
// **********************************************************************

using System;
using UniRx;

public partial class ChatPlayerItemController:MonolessViewController<ChatPlayerItem>
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        ContentBg_UIButtonEvt = View.ContentBg_UIButton.AsObservable();
        IconBg_UIButtonEvt = View.IconBg_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        ContentBg_UIButtonEvt = ContentBg_UIButtonEvt.CloseOnceNull();
        IconBg_UIButtonEvt = IconBg_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> ContentBg_UIButtonEvt;
    public UniRx.IObservable<Unit> OnContentBg_UIButtonClick{
        get {return ContentBg_UIButtonEvt;}
    }

    private Subject<Unit> IconBg_UIButtonEvt;
    public UniRx.IObservable<Unit> OnIconBg_UIButtonClick{
        get {return IconBg_UIButtonEvt;}
    }


}
