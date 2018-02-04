﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class FormationPosView : BaseView
{
    public const string NAME ="FormationPosView";

    #region Element Bindings

    /// bind gameobject
    public UIButton InfoBtn_UIButton;
    public UIGrid BtnGrid_UIGrid;
    public UIGrid ItemGrid_UIGrid;
    public UIButton EnterBtn_UIButton;
    public UIButton PlayerPosBtn_UIButton;
    public UIButton TeamPosBtn_UIButton;
    public Transform SelectSprite_Transform;
    public UILabel DescLb_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        InfoBtn_UIButton = root.FindScript<UIButton>("InfoBtn");
        BtnGrid_UIGrid = root.FindScript<UIGrid>("ScrollView/BtnGrid");
        ItemGrid_UIGrid = root.FindScript<UIGrid>("ScrollView/ItemGrid");
        EnterBtn_UIButton = root.FindScript<UIButton>("EnterBtn");
        PlayerPosBtn_UIButton = root.FindScript<UIButton>("PlayerPosBtn");
        TeamPosBtn_UIButton = root.FindScript<UIButton>("TeamPosBtn");
        SelectSprite_Transform = root.FindTrans("ScrollView/SelectSprite");
        DescLb_UILabel = root.FindScript<UILabel>("ScrollView/DescLb");

    }
    #endregion
}