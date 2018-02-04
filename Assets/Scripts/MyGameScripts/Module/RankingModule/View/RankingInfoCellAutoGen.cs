﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class RankingInfoCell : BaseView
{
    public const string NAME ="RankingInfoCell";

    #region Element Bindings

    /// bind gameobject
    public UIButton TipsBtn_UIButton;
    public UILabel MyScore_UILabel;
    public UILabel MyRank_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        TipsBtn_UIButton = root.FindScript<UIButton>("TipsBtn");
        MyScore_UILabel = root.FindScript<UILabel>("MyScore");
        MyRank_UILabel = root.FindScript<UILabel>("MyRank");

    }
    #endregion
}
