﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : MarsZ
// Created : 03/30/2017 15:44:57
// Desc	: Auto generated by MarsZ. update this if need.
// **********************************************************************

using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// This is the controller class for module BattleAutoSummonConfig, use this to control the ui or view , such as it's init , update or dispose.
/// @MarsZ in 03/30/2017 15:44:57
/// </summary>
public class BattleAutoSummonConfigController : MonoViewController<BattleAutoSummonConfigView>
{
    #region property and field

    #region const

    #endregion


    #region data

    private UIButton mCurrentSelectedQuality;
    private Dictionary<int,BattleAutoSummonHeroController> mHeroItemHashDic;

    #endregion

    #endregion

    #region interface functions

    /// <summary>
    /// 界面就绪后初始化，一个UI生命周期只会执行一次
    /// </summary>
    protected override void AfterInitView()
    {
        mCurrentSelectedQuality = null;
        mHeroItemHashDic = new Dictionary<int, BattleAutoSummonHeroController>();
        InitCurrentUsedHeroCard();
        InitSelectedList();
        InitQualityList();
    }

    //添加事件监听 在gameeventlistener和eventlistener中添加的回调不需要自己remove，所以没有一个相应的RemoveCustomEvent函数
    protected override void RegistCustomEvent()
    {
        EventDelegate.Set(View.BtnClose_UIButton.onClick, ProxyBattleConfigModule.CloseAutoSummonConfig);
        EventDelegate.Set(View.CurrentLv_UIButton.onClick, OnCurrentLvBtnClick);

    }

    //收到界面销毁后的回收处理，比如引用置空等
    protected override void OnDispose()
    {
        mHeroItemHashDic.Clear();
    }

    #endregion

    #region Event Handlers

    private void OnCurrentLvBtnClick()
    {
        ShowQualitySelect = !ShowQualitySelect;   
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
        ShowQualitySelect = false;
        UpdateCurrentUsedHeroCard();
        UpdateSelectedList();
        UpdateSelectedQuality();
    }

    private BattleAutoSummonHeroController CreateDragableHeroCardItemController(GameObject pParent,
                                                                                BattleAutoSummonHeroController.PositionType pPosition = BattleAutoSummonHeroController.PositionType.ToBeSelected)
    {
        BattleAutoSummonHeroController tDragableHeroCardItemController = AddCachedChild<BattleAutoSummonHeroController,HeroCardItem>(pParent, HeroCardItem.NAME);
        tDragableHeroCardItemController.Positon = pPosition;
        tDragableHeroCardItemController.Selected = false;
        tDragableHeroCardItemController.DragEnable = true;
        tDragableHeroCardItemController.DragDropEnable = true;
        tDragableHeroCardItemController.OnDragDropReleaseHandler = OnDragDropReleaseHandler;
        mHeroItemHashDic.Add(tDragableHeroCardItemController.gameObject.GetInstanceID(), tDragableHeroCardItemController);
        return tDragableHeroCardItemController;
    }

    //创建不可拖拽的卡牌（卡槽）
    private BattleAutoSummonHeroController CreateUndragableHeroCardItemController(GameObject pParent,
                                                                                  BattleAutoSummonHeroController.PositionType pPosition = BattleAutoSummonHeroController.PositionType.ToBeSelected)
    {
        BattleAutoSummonHeroController tBattleAutoSummonHeroController = CreateDragableHeroCardItemController(pParent, pPosition);
        tBattleAutoSummonHeroController.DragEnable = false;
        tBattleAutoSummonHeroController.DragDropEnable = false;
        tBattleAutoSummonHeroController.OnDragDropReleaseHandler = null;
        return tBattleAutoSummonHeroController;
    }

    private Transform GetCardParent(BattleAutoSummonHeroController.PositionType pTargetPositionType)
    {
        switch (pTargetPositionType)
        {
            case BattleAutoSummonHeroController.PositionType.CurrentUsed:
                return View.CurrentUsedHero.transform;
            case BattleAutoSummonHeroController.PositionType.CurrentSelected:
                return View.GridCardPostion_UIGrid.transform;
            case BattleAutoSummonHeroController.PositionType.ToBeSelected:
                return View.GridCardList_UIGrid.transform;
            default:
                break;
        }
        return null;
    }

    #endregion

    #region 拖拽

    private void OnDragDropReleaseHandler(BattleAutoSummonHeroController pDragedHeroItem, GameObject pSurface, Vector3 pDragStartPosition)
    {
        BattleAutoSummonHeroController tSurfaceHeroItem = GetHeroItemByGameObject(pSurface);
        //拖拽到了空白地方，不替换
        if (null == tSurfaceHeroItem)
        {
            pDragedHeroItem.transform.position = pDragStartPosition;
            return;
        }
        //拖拽到卡槽，释放到卡槽位置
        else if (tSurfaceHeroItem.HeroUID <= 0)
        {
            //父节点不一样，因为层级问题。
            DragToPosition(pDragedHeroItem, GetCardParent(tSurfaceHeroItem.Positon), tSurfaceHeroItem.transform.position, tSurfaceHeroItem.Positon);
        }
        else
        {
            
            //拖拽到列表，则为取消选择或取消使用
            if (tSurfaceHeroItem.Positon == BattleAutoSummonHeroController.PositionType.ToBeSelected)
            {
                if (pDragedHeroItem.Positon != BattleAutoSummonHeroController.PositionType.ToBeSelected)
                {
                    DragToCard(pDragedHeroItem, tSurfaceHeroItem);
                    View.GridCardList_UIGrid.RepositionDelay();
                    return;
                }
            }
            //拖拽到卡片，交换位置
            pDragedHeroItem.transform.ChangeParent(pSurface.transform);
            pSurface.transform.position = pDragStartPosition;
            UpdateHeroItemPosition(pDragedHeroItem, tSurfaceHeroItem);
        }
    }

    private void DragToCard(BattleAutoSummonHeroController pDragedHeroItem, BattleAutoSummonHeroController pSurfaceHeroItem)
    {
        DragToPosition(pDragedHeroItem, pSurfaceHeroItem.transform.parent, pSurfaceHeroItem.transform.position, pSurfaceHeroItem.Positon);
    }

    private void DragToPosition(BattleAutoSummonHeroController pDragedHeroItem, Transform pTargetParent, Vector3 pTargetPosition, BattleAutoSummonHeroController.PositionType pTargetPositionType)
    {
        if (pDragedHeroItem.transform.parent == pTargetParent)
            return;
        pDragedHeroItem.transform.SetParent(pTargetParent);
        pDragedHeroItem.transform.position = pTargetPosition;
        NGUITools.MarkParentAsChanged(pDragedHeroItem.gameObject);
        UpdateHeroItemPosition(pDragedHeroItem, pTargetPositionType);
    }

    private void UpdateHeroItemPosition(BattleAutoSummonHeroController pDragedHeroItem, BattleAutoSummonHeroController pSurfaceHeroItem)
    {
        BattleAutoSummonHeroController.PositionType tTempPositionType = pDragedHeroItem.Positon;
        UpdateHeroItemPosition(pDragedHeroItem, pSurfaceHeroItem.Positon);
        UpdateHeroItemPosition(pSurfaceHeroItem, tTempPositionType);
    }

    private void UpdateHeroItemPosition(BattleAutoSummonHeroController pHeroItem, BattleAutoSummonHeroController.PositionType pPositionType)
    {
        pHeroItem.Positon = pPositionType;
        GameDebuger.LogError(string.Format("[TODO]等待协议：更新位置类型，英雄（id：{0}，位置：{1}）", 
                pHeroItem.HeroUID, pPositionType));
    }

    private BattleAutoSummonHeroController GetHeroItemByGameObject(GameObject pGameObject)
    {
        if (null == pGameObject)
            return null;
        return GetHeroItemByGameObject(pGameObject.GetInstanceID());
    }

    private BattleAutoSummonHeroController GetHeroItemByGameObject(int pGameObjectInstanceId)
    {
        if (null == mHeroItemHashDic || mHeroItemHashDic.Count <= 0)
            return null;
        BattleAutoSummonHeroController tBattleAutoSummonHeroController = null;
        mHeroItemHashDic.TryGetValue(pGameObjectInstanceId, out tBattleAutoSummonHeroController);
        return tBattleAutoSummonHeroController;
    }

    #endregion

    #region 当前出战的武将

    private void InitCurrentUsedHeroCard()
    {
        CreateUndragableHeroCardItemController(View.CurrentUsedHeroBG, BattleAutoSummonHeroController.PositionType.CurrentUsed);
    }

    private void UpdateCurrentUsedHeroCard()
    {
        CreateDragableHeroCardItemController(View.CurrentUsedHero, BattleAutoSummonHeroController.PositionType.CurrentUsed).UpdateData(ModelManager.BattleConfig.GetCurrentUsedHero());
    }

    #endregion

    #region 已选列表

    private void InitSelectedList()
    {
        //卡槽
        for (int tCounter = 0; tCounter < 5; tCounter++)
        {
            CreateUndragableHeroCardItemController(View.GridCardPostionBG_UIGrid.gameObject, 
                BattleAutoSummonHeroController.PositionType.CurrentSelected);
        }
        View.GridCardPostionBG_UIGrid.RepositionDelay();
    }

    private void UpdateSelectedList()
    {
        List<long> tSelectedHeroUIDList = ModelManager.BattleConfig.GetCurrentSelectedHero();
        BattleAutoSummonHeroController tBattleAutoSummonHeroController = null;
        long tHeroUID;
        for (int tCounter = 0, tLen = tSelectedHeroUIDList.Count; tCounter < tLen; tCounter++)
        {
            tBattleAutoSummonHeroController = CreateDragableHeroCardItemController(View.GridCardPostion_UIGrid.gameObject, 
                BattleAutoSummonHeroController.PositionType.CurrentSelected);
            tHeroUID = tSelectedHeroUIDList[tCounter];
            tBattleAutoSummonHeroController.UpdateData(tHeroUID);
        }
        View.GridCardPostion_UIGrid.RepositionDelay();
    }

    #endregion

    #region 可选列表

    private void UpdateCanSelectList(int pQuality)
    {
        List<long> tHeroList = ModelManager.BattleConfig.GetHeroList();
        BattleAutoSummonHeroController tDragableHeroCardItemController = null;
        long tHeroID;
        for (int tCounter = 0; tCounter < tHeroList.Count; tCounter++)
        {
            tHeroID = tHeroList[tCounter];
            tDragableHeroCardItemController = CreateDragableHeroCardItemController(View.GridCardList_UIGrid.gameObject);
            tDragableHeroCardItemController.UpdateData(tHeroID);

            if (CanSelect(tDragableHeroCardItemController, pQuality))
            {
                tDragableHeroCardItemController.transform.SetParent(View.GridCardList_UIGrid.transform);
                tDragableHeroCardItemController.Show();
                continue;
            }
            tDragableHeroCardItemController.Hide();
            tDragableHeroCardItemController.transform.SetParent(View.transform);
        }
        RepositionDelay();
    }

    private void RepositionDelay()
    {
        View.GridCardList_UIGrid.RepositionDelay(() =>
            {
                View.ScrollViewCardList_UIScrollView.ResetPosition();
            });
    }

    private bool CanSelect(BattleAutoSummonHeroController pDragableHeroCardItemController, int pQuality)
    {
        return null != pDragableHeroCardItemController && (pDragableHeroCardItemController.Quality == pQuality || pQuality == 0);
    }

    #endregion

    #region 品质列表

    private void InitQualityList()
    {
        Transform tTransform = null;
        UIButton tUIToggle = null;
        for (int tCounter = 0, tLen = View.CntrLvs_Transform.childCount; tCounter < tLen; tCounter++)
        {
            tTransform = View.CntrLvs_Transform.GetChild(tCounter);
            tUIToggle = tTransform.GetComponent<UIButton>();
            EventDelegate.Set(tUIToggle.onClick, OnQualityChange);
        }
    }

    private void OnQualityChange()
    {
        mCurrentSelectedQuality = UIButton.current;
        ShowQualitySelect = false;
        UpdateSelectedQuality();
    }

    private void UpdateSelectedQuality()
    {
        int tSelectedQuality = null != mCurrentSelectedQuality ? mCurrentSelectedQuality.gameObject.name.ToInt() : 0;
        if (null != mCurrentSelectedQuality)
        {
            View.CurrentLv_UIButton.normalSprite = mCurrentSelectedQuality.normalSprite;
            View.CurrentLv_UIButton.sprite.color = mCurrentSelectedQuality.defaultColor;
        }
        UpdateCanSelectList(tSelectedQuality);
    }

    private bool mShowQualitySelect = true;

    private bool ShowQualitySelect
    {
        get
        { 
            return mShowQualitySelect;
        }
        set
        {
            if (mShowQualitySelect != value)
            {
                mShowQualitySelect = value;
                ShowQualitySelectUI(mShowQualitySelect);
            }
        }
    }

    private void ShowQualitySelectUI(bool pShow)
    {
        View.CntrLvs_UIWidget.alpha = pShow ? 1F : 0F;
    }

    #endregion
}