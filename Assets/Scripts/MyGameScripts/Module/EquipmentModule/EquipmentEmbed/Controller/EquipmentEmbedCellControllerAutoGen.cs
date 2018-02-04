﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  EquipmentEmbedCellController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface IEquipmentEmbedCellController
{
     UniRx.IObservable<Unit> OnEquipmentEmbedCell_UIButtonClick{get;}

}

public partial class EquipmentEmbedCellController:MonolessViewController<EquipmentEmbedCell>, IEquipmentEmbedCellController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        EquipmentEmbedCell_UIButtonEvt = View.EquipmentEmbedCell_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        EquipmentEmbedCell_UIButtonEvt = EquipmentEmbedCell_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> EquipmentEmbedCell_UIButtonEvt;
    public UniRx.IObservable<Unit> OnEquipmentEmbedCell_UIButtonClick{
        get {return EquipmentEmbedCell_UIButtonEvt;}
    }


}