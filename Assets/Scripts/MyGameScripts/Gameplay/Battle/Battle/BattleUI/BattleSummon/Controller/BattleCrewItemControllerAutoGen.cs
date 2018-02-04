﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  BattleCrewItemController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IBattleCrewItemController
{
     UniRx.IObservable<Unit> OnItemBtn_UIButtonClick{get;}

}

public partial class BattleCrewItemController:MonolessViewController<BattleCrewItem>, IBattleCrewItemController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        ItemBtn_UIButtonEvt = View.ItemBtn_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        ItemBtn_UIButtonEvt = ItemBtn_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> ItemBtn_UIButtonEvt;
    public UniRx.IObservable<Unit> OnItemBtn_UIButtonClick{
        get {return ItemBtn_UIButtonEvt;}
    }


}
