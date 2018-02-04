﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : MarsZ
// Created : 08/15/2016 15:57:59
// Desc : Auto generated by MarsZ. update this if need.
// **********************************************************************

using UnityEngine;
using System.Collections.Generic;
using AppDto;
using AppServices;
using System.Collections;

/// <summary>
/// This is the controller class for module BattleMagicEquipSelect, use this to control the ui or view , such as it's init , update or dispose.
/// @MarsZ in 08/15/2016 15:57:59
/// </summary>
public class BattleMagicEquipSelectController : MonoViewController<BattleMagicEquipSelectView>
{
//    private System.Action<MonsterController, MagicEquipmentDto, MagicEquipmentActiveSkill> OnSkillSelectHandler;
    private MonsterController mMonsterController;

    #region interface functions

//    public void Open(MonsterController pMonsterController, System.Action<MonsterController, MagicEquipmentDto, MagicEquipmentActiveSkill> OnSkillSelect)
//    {
//        OnSkillSelectHandler = OnSkillSelect;
//        mMonsterController = pMonsterController;
//        UpdateData();
//    }

    protected override void AfterInitView ()
    {
        UpdateStaticData();
        InitItemList();
    }

    protected override void RegistCustomEvent ()
    {
        View.Table_UIRecycledList.onUpdateItem = OnUpdateItemInfo;
    }

    protected override void OnDispose()
    {
        StopAllCoroutines();
        View.Table_UIRecycledList.onUpdateItem = null;
    }

    #endregion

    #region Public or open interface

    /// <summary>
    /// 更新界面的全部数据和显示
    /// </summary>
    public void UpdateData()
    {
        UpdateDynamicData();
        UpdateAllUI();
    }

    #endregion

    #region Update global info data

    /// <summary>
    /// 更新那些动态的网络相关的信息
    /// </summary>
    private void UpdateDynamicData()
    {
        GameDebuger.TODO("dataList = ModelManager.MagicEquipment.GetAllWearMagicEquipment();");
    }

    /// <summary>
    /// 更新吧静态配置数据
    /// </summary>
    private void UpdateStaticData()
    {
    }

    #endregion

    #region 更新列表

//    private List<MagicEquipmentDto> dataList;
    private Dictionary<GameObject, BattleMagicEquipCellController> _itemDic = new Dictionary<GameObject, BattleMagicEquipCellController>();

    private void UpdateAllUI()
    {
        UpdateItemList();
        UpdateMagicValue();
    }

    private void InitItemList()
    {
        InitItemList(View.Table_UIRecycledList, _itemDic);
    }

    private void InitItemList(UIRecycledList pUIRecycledList, Dictionary<GameObject, BattleMagicEquipCellController> pDataList)
    {
        if (null != pUIRecycledList)
        {
            pDataList.Clear();

            for (int i = 0; i < 3; ++i)
            {
                var com = AddCachedChild<BattleMagicEquipCellController, BattleMagicEquipCell>(
                    pUIRecycledList.gameObject
                    , BattleMagicEquipCell.NAME
                );

                var item = com.gameObject;
                item.transform.localPosition = new Vector3(i * pUIRecycledList.itemSize, 0f, 0f);
                item.name = BattleMagicEquipCell.NAME + i;
                pDataList.Add(item, com);
            }
        }
    }

    private void UpdateItemList()
    {
        int tCount = 0;
        GameDebuger.TODO(@"if (null != dataList && dataList.Count > 0)
        {
            tCount = dataList.Count;
        }");
        View.Table_UIRecycledList.UpdateDataCount(tCount, true);
        UpdateGridBG(tCount);
    }

    private void UpdateGridBG(int pAddCount)
    {
        View.BGSprite_UISprite.height = 133 + 110 * pAddCount;
    }

    private void OnUpdateItemInfo(GameObject item, int itemIndex, int dataIndex)
    {
        OnUpdateItemInfo(item, itemIndex, dataIndex, _itemDic);
    }

    private void OnUpdateItemInfo(GameObject item, int itemIndex, int dataIndex, Dictionary<GameObject, BattleMagicEquipCellController> pDic)
    {
        if (null != pDic)
        {
            BattleMagicEquipCellController com = null;
            if (pDic.TryGetValue(item, out com))
            {
                GameDebuger.TODO(@"if (dataList != null && dataIndex < dataList.Count)
                {
                    com.UpdateData(dataList[dataIndex], OnItemSelectedHandler);
                }
                else
                {
                    com.UpdateData(null, null);
                }");
            }
        }
    }

    private void OnListUpdateHandler()
    {
        if (UIHelper.IsViewUpdateEnable(View))
        {
            UpdateData();
        }
    }

//    private void OnItemSelectedHandler(MagicEquipmentDto pMagicEquipmentDto, MagicEquipmentActiveSkill pMagicEquipmentActiveSkill)
//    {
//        if (null != pMagicEquipmentDto && null != pMagicEquipmentActiveSkill)
//        {
//            ProxyBattleModule.CloseMagicEquipSelect();
//            if (null != OnSkillSelectHandler)
//                OnSkillSelectHandler(mMonsterController, pMagicEquipmentDto, pMagicEquipmentActiveSkill);
//        }
//    }

    #endregion

    #region 更新需要的法力信息

    private void UpdateMagicValue()
    {
        GameDebuger.TODO(@"
int tCurMagicValue = ModelManager.MagicEquipmentUpGrade.GetHasMagicValue();
        int tMaxMagicValue = ModelManager.MagicEquipmentUpGrade.MaxMagicValue;
        UpdateMagicValue(tCurMagicValue, tMaxMagicValue);        
");
    }

    private void UpdateMagicValue(int pCurMagicValue, int pMaxMagicValue)
    {
        View.LabelMagicValue_UILabel.text = string.Format("法力：{0}/{1}", pCurMagicValue, pMaxMagicValue);
    }

    #endregion
}