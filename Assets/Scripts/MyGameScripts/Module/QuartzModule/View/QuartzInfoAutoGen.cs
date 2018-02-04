﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class QuartzInfo : BaseView
{
    public const string NAME ="QuartzInfo";

    #region Element Bindings

    /// bind gameobject
    public UIScrollView ScrollView_UIScrollView;
    public GameObject InfoGroup;
    public GameObject AllAnchor;
    public UIGrid WarGrid_UIGrid;
    public UIButton HighInfoBtn_UIButton;
    public UIGrid TabGrid_UIGrid;
    public GameObject ItemInfoGroup;
    public UIScrollView AllScrollView_UIScrollView;
    public UIGrid AllGrid_UIGrid;
    public GameObject WearAnchor;
    public Transform QuartzGrid_Transform;
    public UIGrid MagicInfoGrid_UIGrid;
    public GameObject ItemExpandGroup;
    public UIGrid EquipGrid_UIGrid;
    public GameObject EquipGroup;
    public UIButton ArrowBtn_UIButton;
    public GameObject ScrollWidget;
    public GameObject SliderTitle;
    public GameObject ItemExpantView;
    public UIGrid ItemExpandTab_UIGrid;
    public UIGrid BaseGrid_UIGrid;
    public UIPanel ItemExpandGroup_UIPanel;
    public Transform Texture_Transform;
    public Transform LinkGrid_Transform;
    public UIButton BaseInfoBtn_UIButton;
    public UIButton SecondInfoBtn_UIButton;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        ScrollView_UIScrollView = root.FindScript<UIScrollView>("ScrollView");
        InfoGroup = root.FindGameObject("InfoGroup");
        AllAnchor = root.FindGameObject("InfoGroup/EquipGroup/AllAnchor");
        WarGrid_UIGrid = root.FindScript<UIGrid>("InfoGroup/ItemInfoGroup/WarGrid");
        HighInfoBtn_UIButton = root.FindScript<UIButton>("InfoGroup/ItemInfoGroup/HighInfoBtn");
        TabGrid_UIGrid = root.FindScript<UIGrid>("InfoGroup/TabGrid");
        ItemInfoGroup = root.FindGameObject("InfoGroup/ItemInfoGroup");
        AllScrollView_UIScrollView = root.FindScript<UIScrollView>("InfoGroup/EquipGroup/AllScrollView");
        AllGrid_UIGrid = root.FindScript<UIGrid>("InfoGroup/EquipGroup/AllScrollView/AllGrid");
        WearAnchor = root.FindGameObject("InfoGroup/EquipGroup/WearAnchor");
        QuartzGrid_Transform = root.FindTrans("QuartzGrid");
        MagicInfoGrid_UIGrid = root.FindScript<UIGrid>("ScrollView/MagicInfoGrid");
        ItemExpandGroup = root.FindGameObject("ItemExpandGroup");
        EquipGrid_UIGrid = root.FindScript<UIGrid>("InfoGroup/EquipGroup/EquipScrollView/EquipGrid");
        EquipGroup = root.FindGameObject("InfoGroup/EquipGroup");
        ArrowBtn_UIButton = root.FindScript<UIButton>("SliderTitle/ArrowBtn");
        ScrollWidget = root.FindGameObject("ScrollWidget");
        SliderTitle = root.FindGameObject("SliderTitle");
        ItemExpantView = root.FindGameObject("ItemExpandGroup/ItemExpantView");
        ItemExpandTab_UIGrid = root.FindScript<UIGrid>("ItemExpandGroup/ItemExpandTab");
        BaseGrid_UIGrid = root.FindScript<UIGrid>("InfoGroup/ItemInfoGroup/BaseGrid");
        ItemExpandGroup_UIPanel = root.FindScript<UIPanel>("ItemExpandGroup");
        Texture_Transform = root.FindTrans("Texture");
        LinkGrid_Transform = root.FindTrans("LinkGrid");
        BaseInfoBtn_UIButton = root.FindScript<UIButton>("InfoGroup/ItemInfoGroup/BaseInfoBtn");
        SecondInfoBtn_UIButton = root.FindScript<UIButton>("InfoGroup/ItemInfoGroup/SecondInfoBtn");

    }
    #endregion
}