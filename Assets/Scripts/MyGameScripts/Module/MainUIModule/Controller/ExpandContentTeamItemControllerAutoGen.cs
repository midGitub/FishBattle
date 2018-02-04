﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  ExpandContentTeamItemController.cs
// the file is generated by tools
// **********************************************************************

using System;
using UniRx;

public partial class ExpandContentTeamItemController:MonolessViewController<ExpandContentTeamItem>
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        ExpandContentTeamItem_UIButtonEvt = View.ExpandContentTeamItem_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        ExpandContentTeamItem_UIButtonEvt = ExpandContentTeamItem_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> ExpandContentTeamItem_UIButtonEvt;
    public UniRx.IObservable<Unit> OnExpandContentTeamItem_UIButtonClick{
        get {return ExpandContentTeamItem_UIButtonEvt;}
    }


}