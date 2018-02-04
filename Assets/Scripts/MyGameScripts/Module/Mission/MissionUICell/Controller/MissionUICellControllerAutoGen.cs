﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  MissionUICellController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IMissionUICellController
{
    UniRx.IObservable<Unit> MissionCell_UIButtonClick { get; }
}

public partial class MissionUICellController:MonolessViewController<MissionUICell>, IMissionUICellController
{
    private Subject<Unit> MissionCell_UIButtonEvt;
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        MissionCell_UIButtonEvt = View.BackGround_UISprite.gameObject.OnClickAsObservable();
    }

    protected override void ClearReactiveEvents(){
        MissionCell_UIButtonEvt = MissionCell_UIButtonEvt.CloseOnceNull();
    }

    public UniRx.IObservable<Unit> MissionCell_UIButtonClick
    {
        get { return MissionCell_UIButtonEvt; }
    }

}