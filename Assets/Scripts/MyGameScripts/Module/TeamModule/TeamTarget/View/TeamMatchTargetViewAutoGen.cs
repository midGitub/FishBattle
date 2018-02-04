﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class TeamMatchTargetView : BaseView
{
    public const string NAME ="TeamMatchTargetView";

    #region Element Bindings

    /// bind gameobject
    public UIButton CloseBtn_UIButton;
    public UILabel MinGradeLb_UILabel;
    public UILabel DescLabel_UILabel;
    public UIToggle autoMatchToggle_UIToggle;
    public UIButton ConfirmBtn_UIButton;
    public UIButton ChangeLvBtn_UIButton;
    public UICenterOnChild RightItemGrid_UICenterOnChild;
    public UIButton CancelBtn_UIButton;
    public UIWrapContent RightItemGrid_UIWrapContent;
    public UIScrollView RightItemScrollView_UIScrollView;
    public UICenterOnChild LeftItemGrid_UICenterOnChild;
    public UITable ItemTable_UITable;
    public GameObject ChangeLvPanel;
    public UIScrollView RightScrollView_UIScrollView;
    public UIWrapContent LeftItemGrid_UIWrapContent;
    public UISprite descBg_UISprite;
    public UIGrid RightTable_UIGrid;
    public UILabel MaxGradeLb_UILabel;
    public UIScrollView LeftItemScrollView_UIScrollView;
    public UIPanel ChangeLvPanel_UIPanel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        CloseBtn_UIButton = root.FindScript<UIButton>("ContentBg/CloseBtn");
        MinGradeLb_UILabel = root.FindScript<UILabel>("ContentBg/RightGroup/ChangeLvPanel/Panel/selectedBg/MinGradeLb");
        DescLabel_UILabel = root.FindScript<UILabel>("ContentBg/RightGroup/descBg/DescLabel");
        autoMatchToggle_UIToggle = root.FindScript<UIToggle>("ContentBg/autoMatchToggle");
        ConfirmBtn_UIButton = root.FindScript<UIButton>("ContentBg/ConfirmBtn");
        ChangeLvBtn_UIButton = root.FindScript<UIButton>("ContentBg/RightGroup/ChangeLvBtn");
        RightItemGrid_UICenterOnChild = root.FindScript<UICenterOnChild>("ContentBg/RightGroup/ChangeLvPanel/RightScroll/RightItemScrollView/RightItemGrid");
        CancelBtn_UIButton = root.FindScript<UIButton>("ContentBg/CancelBtn");
        RightItemGrid_UIWrapContent = root.FindScript<UIWrapContent>("ContentBg/RightGroup/ChangeLvPanel/RightScroll/RightItemScrollView/RightItemGrid");
        RightItemScrollView_UIScrollView = root.FindScript<UIScrollView>("ContentBg/RightGroup/ChangeLvPanel/RightScroll/RightItemScrollView");
        LeftItemGrid_UICenterOnChild = root.FindScript<UICenterOnChild>("ContentBg/RightGroup/ChangeLvPanel/LeftScroll/LeftItemScrollView/LeftItemGrid");
        ItemTable_UITable = root.FindScript<UITable>("ContentBg/LeftGroup/LeftScrollView/ItemTable");
        ChangeLvPanel = root.FindGameObject("ContentBg/RightGroup/ChangeLvPanel");
        RightScrollView_UIScrollView = root.FindScript<UIScrollView>("ContentBg/RightGroup/ScrollView/RightScrollView");
        LeftItemGrid_UIWrapContent = root.FindScript<UIWrapContent>("ContentBg/RightGroup/ChangeLvPanel/LeftScroll/LeftItemScrollView/LeftItemGrid");
        descBg_UISprite = root.FindScript<UISprite>("ContentBg/RightGroup/descBg");
        RightTable_UIGrid = root.FindScript<UIGrid>("ContentBg/RightGroup/ScrollView/RightScrollView/RightTable");
        MaxGradeLb_UILabel = root.FindScript<UILabel>("ContentBg/RightGroup/ChangeLvPanel/Panel/selectedBg/MaxGradeLb");
        LeftItemScrollView_UIScrollView = root.FindScript<UIScrollView>("ContentBg/RightGroup/ChangeLvPanel/LeftScroll/LeftItemScrollView");
        ChangeLvPanel_UIPanel = root.FindScript<UIPanel>("ContentBg/RightGroup/ChangeLvPanel");

    }
    #endregion
}
