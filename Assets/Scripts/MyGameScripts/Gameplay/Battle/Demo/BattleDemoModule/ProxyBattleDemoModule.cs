﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : MarsZ
// Created : 01/19/2017 20:38:46
// Desc	: Auto generated by MarsZ. update this if need.
// **********************************************************************

using AppDto;
using System;
using System.Collections.Generic;


/// <summary>
/// This is the proxy class for module BattleDemoS1Main, use this to show or hide this module.
/// @MarsZ in 01/19/2017 20:38:46
/// </summary>
public static class ProxyBattleDemoModule
{
    public static void Hide()
    {
        UIModuleManager.Instance.HideModule(BattleDemoView.NAME);	
    }

    #region NAME_BattleSkillSelect


    public static void OpenSkillSelect(MonsterController mc, Action<Skill> OnSkillSelect)
    {
        var controller = UIModuleManager.Instance.OpenFunModule<BattleSkillSelectController>(BattleSkillSelectView.NAME, UILayerType.DefaultModule, true);
        controller.Open(mc, OnSkillSelect);
    }

    public static void OpenGuideSkillSelect(MonsterController mc, Action<Skill> OnSkillSelect)
    {
        var ui = UIModuleManager.Instance.OpenFunModule(BattleSkillSelectView.NAME, UILayerType.DefaultModule, true);
        var controller = ui.GetMissingComponent<BattleSkillSelectController>();
        controller.OpenGuide(mc, OnSkillSelect);
    }

    public static void HideSkillSelect()
    {
        UIModuleManager.Instance.HideModule(BattleSkillSelectView.NAME);
    }

    #endregion

    #region NAME_BattleStuntSelect

    public static void OpenStuntSelect(MonsterController mc, List<int> skills, Action<Skill> OnStuntSelect)
    {
        var controller = UIModuleManager.Instance.OpenFunModule<BattleSkillSelectController>(BattleSkillSelectView.NAME, UILayerType.DefaultModule, true);
        controller.OpenStunt(mc, skills, OnStuntSelect);
    }

    public static void CloseStuntSelect()
    {
        UIModuleManager.Instance.CloseModule(BattleSkillSelectView.NAME);
    }

    public static void HideStuntSelect()
    {
        UIModuleManager.Instance.HideModule(BattleSkillSelectView.NAME);
    }

    #endregion

    #region 战斗指挥

    public static void OpenBattleOrderListView(int orderType, long targetId, System.Action<BattleOrderInfo> pOrderSelectedHandler)
    {
        var com = UIModuleManager.Instance.OpenFunModule<BattleOrderListViewController>(
            BattleOrderListView.NAME
            , UILayerType.ThreeModule
            , false);
        com.Open(orderType, targetId, pOrderSelectedHandler);
    }

    public static void HideBattleOrderListView()
    {
        UIModuleManager.Instance.HideModule(BattleOrderListView.NAME);
    }

    public static void CloseBattleOrderListView()
    {
        UIModuleManager.Instance.CloseModule(BattleOrderListView.NAME);
    }

    public static bool IsBattleOrderListViewOpening()
    {
        return UIModuleManager.Instance.IsModuleCacheContainsModule(BattleOrderListView.NAME);
    }

    public static void OpenBattleOrderEditorView(int orderType)
    {
        var com = UIModuleManager.Instance.OpenFunModule<BattleOrderEditorViewController>(
            BattleOrderEditorView.NAME
            , UILayerType.ThreeModule + 1
            , true
            , false);
        com.orderType = orderType;
        com.setData();

        GameDebuger.TODO(@"CloseBattleBuffTipsView();");
    }

    public static bool IsBattleOrderEditorViewOpening()
    {
        return UIModuleManager.Instance.IsModuleCacheContainsModule(BattleOrderEditorView.NAME);
    }

    public static void CloseBattleOrderEditorView()
    {
        UIModuleManager.Instance.CloseModule(BattleOrderEditorView.NAME);
    }

    #endregion

    #region 战斗结算
    public static void ShowPVPFailView()
    {
        var ctrl = UIModuleManager.Instance.OpenFunModule<BattlePVPFailViewController>(BattlePVPFailView.NAME,
            UILayerType.ThreeModule, true);
        ctrl.SetViewInfo();
    }

    public static void ClosePVPFailView()
    {
        UIModuleManager.Instance.CloseModule(BattlePVPFailView.NAME);
    }

    public static void ShowPVEFailView()
    {
        var ctrl = UIModuleManager.Instance.OpenFunModule<BattlePVEFailViewController>(BattlePVPFailView.NAME,
            UILayerType.ThreeModule, true);
    }

    public static void ClosePVEFailView()
    {
        UIModuleManager.Instance.CloseModule(BattlePVEFailView.NAME);
    }
    #endregion


    public static void OpenSkillSelView()
    {
    }
    //    #region 法宝技能选择
    //    public static void OpenMagicEquipSelect(MonsterController pMonsterController,Action<MonsterController,MagicEquipmentDto ,MagicEquipmentActiveSkill > OnSkillSelect)
    //  {
    //      GameObject ui = UIModuleManager.Instance.OpenFunModule( BattleMagicEquipSelectView.NAME ,UILayerType.DefaultModule, true);
    //      BattleMagicEquipSelectController controller = ui.GetMissingComponent<BattleMagicEquipSelectController>();
    //      controller.Open (pMonsterController,OnSkillSelect);
    //  }
    //
    //    public static void CloseMagicEquipSelect()
    //  {
    //      UIModuleManager.Instance.CloseModule( BattleMagicEquipSelectView.NAME );
    //  }
    //
    //    public static void HideMagicEquipSelect()
    //  {
    //      UIModuleManager.Instance.HideModule( BattleMagicEquipSelectView.NAME );
    //  }
    //    #endregion

}