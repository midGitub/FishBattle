﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  CrewSkillMagicTipsController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface ICrewSkillMagicTipsController
{
     UniRx.IObservable<Unit> OnbtnUp_UIButtonClick{get;}

}

public partial class CrewSkillMagicTipsController:MonolessViewController<CrewSkillMagicTips>, ICrewSkillMagicTipsController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        btnUp_UIButtonEvt = View.btnUp_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        btnUp_UIButtonEvt = btnUp_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> btnUp_UIButtonEvt;
    public UniRx.IObservable<Unit> OnbtnUp_UIButtonClick{
        get {return btnUp_UIButtonEvt;}
    }


}
