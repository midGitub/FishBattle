﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class GoodsTipsBtnPanelView : BaseView
{
    public const string NAME ="GoodsTipsBtnPanelView";

    #region Element Bindings

    /// bind gameobject
    public UILabel LeftLabel_UILabel;
    public UIButton LeftBtn_UIButton;
    public UIButton RightBtn_UIButton;
    public UILabel RightLabel_UILabel;
    public UISprite LeftExpandBg_UISprite;
    public UISprite RightExpandBg_UISprite;
    public UITable LeftExpandTable_UITable;
    public UITable RightExpandTable_UITable;

    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        LeftLabel_UILabel = root.FindScript<UILabel>("LeftBtn/LeftLabel");
        LeftBtn_UIButton = root.FindScript<UIButton>("LeftBtn");
        RightBtn_UIButton = root.FindScript<UIButton>("RightBtn");
        RightLabel_UILabel = root.FindScript<UILabel>("RightBtn/RightLabel");
        LeftExpandBg_UISprite = root.FindScript<UISprite>("LeftBtn/ExpandBg");
        RightExpandBg_UISprite = root.FindScript<UISprite>("RightBtn/ExpandBg");
        LeftExpandTable_UITable = root.FindScript<UITable>("LeftBtn/ExpandTable");
        RightExpandTable_UITable = root.FindScript<UITable>("RightBtn/ExpandTable");
    }
    #endregion
}
