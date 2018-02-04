﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  RoleSkillCraftsItemController.cs
// the file is generated by tools
// **********************************************************************

using System;
using UniRx;
public partial interface IRoleSkillMagicItemController
{
    UniRx.IObservable<Unit> OnItemClick { get; }
}

public partial class RoleSkillMagicItemController:MonolessViewController<RoleSkillMagicItem>, IRoleSkillMagicItemController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents()
    {
        itemClickEvt = View.gameObject.OnClickAsObservable();

    }

    protected override void ClearReactiveEvents()
    {
        itemClickEvt = itemClickEvt.CloseOnceNull();
    }

    private Subject<Unit> itemClickEvt;
    public UniRx.IObservable<Unit> OnItemClick
    {
        get { return itemClickEvt; }
    }
}
