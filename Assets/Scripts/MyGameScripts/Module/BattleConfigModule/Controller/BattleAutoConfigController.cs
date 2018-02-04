﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : MarsZ
// Created : 03/30/2017 15:27:36
// Desc	: Auto generated by MarsZ. update this if need.
// **********************************************************************

using UnityEngine;
using System.Collections.Generic;
using AppDto;
using AppServices;
using System.Collections;

/// <summary>
/// This is the controller class for module BattleAutoConfig, use this to control the ui or view , such as it's init , update or dispose.
/// @MarsZ in 03/30/2017 15:27:36
/// </summary>
public class BattleAutoConfigController : MonoViewController<BattleAutoConfigView>
{
    #region property and field

    private const int MAX_PET_COUNT = 5;

    #region const

    #endregion


    #region data

    private List<HeroHeadItemController> mHeroHeadItemControllerList;

    #endregion

    #endregion

    #region interface functions

    /// <summary>
    /// 界面就绪后初始化，一个UI生命周期只会执行一次
    /// </summary>
    protected override void AfterInitView()
    {
        InitPetUI();
        MainRoleAutoSkillHeadItem.ShowName = true;
        MainRoleSubSkillHeadItem.ShowName = true;
        MainPetAutoSkillHeadItem.ShowName = true;
        MainRoleSubSkillHeadItem.ShowName = true;
    }

    //添加事件监听 在gameeventlistener和eventlistener中添加的回调不需要自己remove，所以没有一个相应的RemoveCustomEvent函数
    protected override void RegistCustomEvent()
    {
        EventDelegate.Set(View.BtnClose_UIButton.onClick, ProxyBattleConfigModule.CloseAutoConfig);
        EventDelegate.Set(View.ToggleAutoTimeOpen_UIToggle.onChange, OnToggleAutoTimeOpenChange);
        EventDelegate.Set(View.ToggleAutoTime1_UIToggle.onChange, OnToggleAutoTimeChange);
        EventDelegate.Set(View.ToggleSubSkillOpen_UIToggle.onChange, OnToggleSubTimeOpenChange);
        MainRoleAutoSkillCell.OnClickHandler = OnMainRoleAutoSkillHandler;
        MainPetAutoSkillCell.OnClickHandler = OnMainPetAutoSkillHandler;
        MainRoleSubSkillCell.OnClickHandler = OnMainRoleSubSkillHandler;
        MainPetSubSkillCell.OnClickHandler = OnMainPetSubSkillHandler;
        EventDelegate.Set(View.ToggleAutoTargetOpen_UIToggle.onChange, OnToggleAutoTargetOpenChange);
    }

    //收到界面销毁后的回收处理，比如引用置空等
    protected override void OnDispose()
    {
        mHeroHeadItemControllerList.Clear();
    }

    #endregion

    #region Event Handlers

    private void OnToggleAutoTimeOpenChange()
    {
        ModelManager.BattleConfig.AutoFightIfOutTime = View.ToggleAutoTimeOpen_UIToggle.value;
        UpdateAutoFightTimeUI();
    }

    private void OnToggleAutoTimeChange()
    {
        ModelManager.BattleConfig.AutoFightTime = View.ToggleAutoTime1_UIToggle.value ? 30 : 60;
    }

    private void OnToggleSubTimeOpenChange()
    {
        ModelManager.BattleConfig.UseSubSkill = View.ToggleSubSkillOpen_UIToggle.value;
    }

    private void OnToggleAutoTargetOpenChange()
    {
        ModelManager.BattleConfig.AutoTarget = View.ToggleAutoTargetOpen_UIToggle.value;
    }

    #endregion

    #region Public or open interface

    /// <summary>
    /// 更新界面的全部数据和显示
    /// </summary>
    public void Open()
    {
        UpdateAllUI();
    }

    #endregion

    #region Update global UI

    private void UpdateAllUI()
    {
        UpdateMainRolePetUI();
        UpdateSkillUI();
        UpdatePetUI();
    }

    #endregion

    #region 自动战斗时间

    private void UpdateAutoFightTimeUI()
    {
        bool tEnable = View.ToggleAutoTimeOpen_UIToggle.value;
        View.ToggleAutoTime1_UIButton.sprite.isGrey = View.ToggleAutoTime2_UIButton.sprite.isGrey = !tEnable;
        View.ToggleAutoTime1_UIButton.isEnabled = View.ToggleAutoTime2_UIButton.isEnabled = tEnable;
    }

    #endregion

    #region 主角主将

    private void UpdateMainRolePetUI()
    {
        MainRoleAutoSkillHeadItem.UpdateData(ModelManager.Player.GetPlayer());
        MainRoleSubSkillHeadItem.UpdateData(ModelManager.Player.GetPlayer());
        MainPetAutoSkillHeadItem.UpdateData(ModelManager.BattleConfig.GetInFightPet());
        MainPetSubSkillHeadItem.UpdateData(ModelManager.BattleConfig.GetInFightPet());
    }

    private HeroHeadItemController mMainRoleAutoSkillHeadItem;

    private HeroHeadItemController MainRoleAutoSkillHeadItem
    {
        get
        {
            if (null == mMainRoleAutoSkillHeadItem)
                mMainRoleAutoSkillHeadItem = AddCachedChild<HeroHeadItemController,HeroHeadItem>(View.CntrAutoSkillRole, HeroHeadItem.NAME);
            return mMainRoleAutoSkillHeadItem;
        }
    }

    private HeroHeadItemController mMainPetAutoSkillHeadItem;

    private HeroHeadItemController MainPetAutoSkillHeadItem
    {
        get
        {
            if (null == mMainPetAutoSkillHeadItem)
                mMainPetAutoSkillHeadItem = AddCachedChild<HeroHeadItemController,HeroHeadItem>(View.CntrAutoSkillPet, HeroHeadItem.NAME);
            return mMainPetAutoSkillHeadItem;
        }
    }

    private HeroHeadItemController mMainRoleSubSkillHeadItem;

    private HeroHeadItemController MainRoleSubSkillHeadItem
    {
        get
        {
            if (null == mMainRoleSubSkillHeadItem)
                mMainRoleSubSkillHeadItem = AddCachedChild<HeroHeadItemController,HeroHeadItem>(View.CntrSubSkillRole, HeroHeadItem.NAME);
            return mMainRoleSubSkillHeadItem;
        }
    }

    private HeroHeadItemController mMainPetSubSkillHeadItem;

    private HeroHeadItemController MainPetSubSkillHeadItem
    {
        get
        {
            if (null == mMainPetSubSkillHeadItem)
                mMainPetSubSkillHeadItem = AddCachedChild<HeroHeadItemController,HeroHeadItem>(View.CntrSubSkillPet, HeroHeadItem.NAME);
            return mMainPetSubSkillHeadItem;
        }
    }

    #endregion

    #region 技能列表

    private void UpdateSkillUI()
    {
        MainRoleAutoSkillCell.UpdateData(ModelManager.BattleConfig.GetRoleAutoFightSkill());
        MainPetAutoSkillCell.UpdateData(ModelManager.BattleConfig.GetPetAutoFightSkill());
        MainRoleSubSkillCell.UpdateData(ModelManager.BattleConfig.GetRoleSubFightSkill());
        MainPetSubSkillCell.UpdateData(ModelManager.BattleConfig.GetPetSubFightSkill());
    }

    private SkillButtonCellController mMainRoleAutoSkillCell;

    private SkillButtonCellController MainRoleAutoSkillCell
    {
        get
        {
            if (null == mMainRoleAutoSkillCell)
                mMainRoleAutoSkillCell = AddCachedChild<SkillButtonCellController,SkillButtonCell>(View.CntrRoleAutoSkill, SkillButtonCell.NAME);
            return mMainRoleAutoSkillCell;
        }
    }

    private SkillButtonCellController mMainPetAutoSkillCell;

    private SkillButtonCellController MainPetAutoSkillCell
    {
        get
        {
            if (null == mMainPetAutoSkillCell)
                mMainPetAutoSkillCell = AddCachedChild<SkillButtonCellController,SkillButtonCell>(View.CntrPetAutoSkill, SkillButtonCell.NAME);
            return mMainPetAutoSkillCell;
        }
    }

    private SkillButtonCellController mMainRoleSubSkillCell;

    private SkillButtonCellController MainRoleSubSkillCell
    {
        get
        {
            if (null == mMainRoleSubSkillCell)
                mMainRoleSubSkillCell = AddCachedChild<SkillButtonCellController,SkillButtonCell>(View.CntrRoleSubSkill, SkillButtonCell.NAME);
            return mMainRoleSubSkillCell;
        }
    }

    private SkillButtonCellController mMainPetSubSkillCell;

    private SkillButtonCellController MainPetSubSkillCell
    {
        get
        {
            if (null == mMainPetSubSkillCell)
                mMainPetSubSkillCell = AddCachedChild<SkillButtonCellController,SkillButtonCell>(View.CntrPetSubSkill, SkillButtonCell.NAME);
            return mMainPetSubSkillCell;
        }
    }

    private void OnMainRoleAutoSkillHandler(SkillButtonCellController pSkillButtonCellController, Skill pSkill)
    {
        ProxyBattleConfigModule.OpenAutoSkillConfig(BattleAutoSkillConfigController.BattleConfigSkillType.MainRoleAutoSkill);   
    }

    private void OnMainPetAutoSkillHandler(SkillButtonCellController pSkillButtonCellController, Skill pSkill)
    {
        ProxyBattleConfigModule.OpenAutoSkillConfig(BattleAutoSkillConfigController.BattleConfigSkillType.MainPetAutoSkill);   
    }

    private void OnMainRoleSubSkillHandler(SkillButtonCellController pSkillButtonCellController, Skill pSkill)
    {
        ProxyBattleConfigModule.OpenAutoSkillConfig(BattleAutoSkillConfigController.BattleConfigSkillType.MainRoleSubSkill);   
    }

    private void OnMainPetSubSkillHandler(SkillButtonCellController pSkillButtonCellController, Skill pSkill)
    {
        ProxyBattleConfigModule.OpenAutoSkillConfig(BattleAutoSkillConfigController.BattleConfigSkillType.MainPetSubSkill);   
    }

    #endregion

    #region 武将列表

    private void InitPetUI()
    {
        mHeroHeadItemControllerList = new List<HeroHeadItemController>(MAX_PET_COUNT);
        HeroHeadItemController tHeroHeadItemController = null;
        for (int tCounter = 0; tCounter < MAX_PET_COUNT; tCounter++)
        {
            tHeroHeadItemController = AddCachedChild<HeroHeadItemController,HeroHeadItem>(View.CntrRoleGrid_UIGrid.gameObject, HeroHeadItem.NAME);
            tHeroHeadItemController.OnClickHandler = OnHeroHeadItemClickHandler;
            mHeroHeadItemControllerList.Add(tHeroHeadItemController);
        }
    }

    private void UpdatePetUI()
    {
        List<long> tAutoHeroList = ModelManager.BattleConfig.GetAutoHeroList();
        HeroHeadItemController tHeroHeadItemController;
        long tAutoHeroUID = 0L;
        for (int tCounter = 0; tCounter < mHeroHeadItemControllerList.Count; tCounter++)
        {
            tAutoHeroUID = (null != tAutoHeroList && tAutoHeroList.Count > tCounter) ? tAutoHeroList[tCounter] : 0L;
            tHeroHeadItemController = mHeroHeadItemControllerList[tCounter];
            tHeroHeadItemController.UpdateData(tAutoHeroUID);
        }
    }

    private void OnHeroHeadItemClickHandler(HeroHeadItemController pHeroHeadItemController, long pHeroUID)
    {
        ProxyBattleConfigModule.OpenAutoSummonConfig();
    }

    #endregion
}
