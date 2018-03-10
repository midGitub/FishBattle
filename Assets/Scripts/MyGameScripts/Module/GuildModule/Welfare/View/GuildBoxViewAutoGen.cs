﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class GuildBoxView : BaseView
{
    public const string NAME ="GuildBoxView";

    #region Element Bindings

    /// bind gameobject
    public UIButton boxCloseBtn_UIButton;
    public UILabel boxLevelLabel_UILabel;
    public UIRecycledList boxEventsGrid_UIRecycledList;
    public UIProgressBar boxSlider_UIProgressBar;
    public UILabel pointsLabel_UILabel;
    public UIButton boxOpenBtn_UIButton;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        boxCloseBtn_UIButton = root.FindScript<UIButton>("boxCloseBtn");
        boxLevelLabel_UILabel = root.FindScript<UILabel>("boxLevelLabel");
        boxEventsGrid_UIRecycledList = root.FindScript<UIRecycledList>("boxEvents/boxEventsGrid");
        boxSlider_UIProgressBar = root.FindScript<UIProgressBar>("boxSlider");
        pointsLabel_UILabel = root.FindScript<UILabel>("pointsLabel");
        boxOpenBtn_UIButton = root.FindScript<UIButton>("boxOpenBtn");

    }
    #endregion
}