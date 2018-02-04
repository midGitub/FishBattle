﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  RoleSkillPotentialViewController.cs
// the file is generated by tools
// **********************************************************************

using System;
using UniRx;
public partial interface IRoleSkillPotentialViewController
{
    UniRx.IObservable<Unit> OnbtnUp_UIButtonClick { get; }
    UniRx.IObservable<Unit> OnbtnUp_10_UIButtonClick { get; }
}

public partial class RoleSkillPotentialViewController:MonolessViewController<RoleSkillPotentialView>, IRoleSkillPotentialViewController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        btnUp_UIButtonEvt = View.btnUp_UIButton.AsObservable();
        btnUp_10_UIButtonEvt = View.btnUp_10_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        btnUp_UIButtonEvt = btnUp_UIButtonEvt.CloseOnceNull();
        btnUp_10_UIButtonEvt = btnUp_10_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> btnUp_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnUp_UIButtonClick{
        get {return btnUp_UIButtonEvt;}
    }

    private Subject<Unit> btnUp_10_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnUp_10_UIButtonClick{
        get {return btnUp_10_UIButtonEvt;}
    }


}
