﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : MarsZ
// Created : 08/15/2016 16:00:14
// Desc : Auto generated by MarsZ. update this if need.
// **********************************************************************

using UnityEngine;
using System.Collections.Generic;
using AppDto;
using AppServices;
using System.Collections;

/// <summary>
/// This is the controller class for module BattleMagicEquipCell, use this to control the ui or view , such as it's init , update or dispose.
/// @MarsZ in 08/15/2016 16:00:14
/// </summary>
public class BattleMagicEquipCellController : MonolessViewController<BattleMagicEquipCell>
{
    #region property and field

    #region const

    #endregion

    #region ui object



    #endregion

    #region data

//    private MagicEquipmentDto mMagicEquipmentDto;
//    private MagicEquipmentActiveSkill mMagicEquipmentActiveSkill;
//    private System.Action<MagicEquipmentDto, MagicEquipmentActiveSkill> mOnItemSelect;

    #endregion

    #endregion

    #region interface functions

    public void Open()
    {
    }

    protected override void AfterInitView()
    {
        UpdateStaticData();
    }

    protected override void RegistCustomEvent ()
    {
        base.RegistCustomEvent();

        EventDelegate.Set(View.BattleMagicEquipCell_UIButton.onClick, OnItemSelectHandler);
    }



    #endregion

    #region Event Handlers

    private void OnItemSelectHandler()
    {
        GameDebuger.TODO(@"if (null != mOnItemSelect)
            mOnItemSelect(mMagicEquipmentDto, mMagicEquipmentActiveSkill);");
    }

    #endregion

    #region Public or open interface

    /// <summary>
    /// 更新界面的全部数据和显示
    /// </summary>
//    public void UpdateData(MagicEquipmentDto pMagicEquipmentDto, System.Action<MagicEquipmentDto, MagicEquipmentActiveSkill> pOnItemClick)
//    {
//        mMagicEquipmentDto = pMagicEquipmentDto;
//        mMagicEquipmentActiveSkill = null;
//        mOnItemSelect = pOnItemClick;
//        UpdateDynamicData();
//        UpdateAllUI();
//    }

    #endregion

    #region Update global info data

    /// <summary>
    /// 更新那些动态的网络相关的信息
    /// </summary>
    private void UpdateDynamicData()
    {
        GameDebuger.TODO(@"if (null != mMagicEquipmentDto && null != mMagicEquipmentDto.itemDto && null != mMagicEquipmentDto.itemDto.item)
        {
            MagicEquipment tMagicEquipment = mMagicEquipmentDto.itemDto.item as MagicEquipment;
            if (null != tMagicEquipment)
            {
                GameDebuger.TODO('mMagicEquipmentActiveSkill = ModelManager.MagicEquipmentUpGrade.GetMagicEquipmentActiveSkill(tMagicEquipment.activeSkillId);');
            }
        }");
    }

    /// <summary>
    /// 更新吧静态配置数据
    /// </summary>
    private void UpdateStaticData()
    {
    }

    #endregion

    #region Update global UI

    private void UpdateAllUI()
    {
        string tName = string.Empty;
        string tDesc = string.Empty;
        string tIcon = string.Empty;
        float tNeedMagic = 0f;
        GameDebuger.TODO(@"
int tHasMagic = ModelManager.MagicEquipmentUpGrade.GetHasMagicValue();

        if (null != mMagicEquipmentDto && null != mMagicEquipmentDto.itemDto && null != mMagicEquipmentDto.itemDto.item)
        {
            MagicEquipment tMagicEquipment = mMagicEquipmentDto.itemDto.item as MagicEquipment;
            if (null != tMagicEquipment)
            {
                tName = tMagicEquipment.name;
                if (null != mMagicEquipmentActiveSkill)
                {
                    tIcon = mMagicEquipmentActiveSkill.icon;
                    tNeedMagic = ModelManager.MagicEquipmentUpGrade.GetNeedMagicValue(mMagicEquipmentActiveSkill);
                    if (tNeedMagic <= tHasMagic)
                    {
                        tDesc = mMagicEquipmentActiveSkill.shortDescription;
                    }
                    else
                    {
                        tDesc = string.Format(""需要{0}点法力"", (int)tNeedMagic).WrapColor(ColorConstantV3.Color_Red_Str);
                    }

                }
            }
        }        
");
        View.NameLabel_UILabel.text = tName;
        View.DescLabel_UILabel.text = tDesc;
        View.LabelCost_UILabel.text = tNeedMagic.ToString();
        UIHelper.SetItemIcon(_view.IconSprite_UISprite, tIcon);
    }

    #endregion
}
