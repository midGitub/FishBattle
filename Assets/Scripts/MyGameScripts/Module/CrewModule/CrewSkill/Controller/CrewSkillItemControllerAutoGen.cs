﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  CrewSkillItemController.cs
// the file is generated by tools
// **********************************************************************


using UniRx;

public partial interface ICrewSkillItemController
{
     UniRx.IObservable<Unit> OnCrewSkillItem_UIButtonClick{get;}

}

public partial class CrewSkillItemController:MonolessViewController<CrewSkillItem>, ICrewSkillItemController
{
    //机器自动生成的事件绑定
    protected override void InitReactiveEvents(){
        CrewSkillItem_UIButtonEvt = View.CrewSkillItem_UIButton.AsObservable();

    }

    protected override void ClearReactiveEvents(){
        CrewSkillItem_UIButtonEvt = CrewSkillItem_UIButtonEvt.CloseOnceNull();

    }

    private Subject<Unit> CrewSkillItem_UIButtonEvt;
    public UniRx.IObservable<Unit> OnCrewSkillItem_UIButtonClick{
        get {return CrewSkillItem_UIButtonEvt;}
    }


}