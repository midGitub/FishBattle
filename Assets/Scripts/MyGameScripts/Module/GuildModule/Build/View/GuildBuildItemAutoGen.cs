﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class GuildBuildItem : BaseView
{
    public const string NAME ="GuildBuildItem";

    #region Element Bindings

    /// bind gameobject
    public UILabel titleLabel_UILabel;
    public UISprite logoSp_UISprite;
    public UILabel DesLabel_UILabel;
    public UIButton checkBtn_UIButton;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        titleLabel_UILabel = root.FindScript<UILabel>("titleBg/titleLabel");
        logoSp_UISprite = root.FindScript<UISprite>("logoSp");
        DesLabel_UILabel = root.FindScript<UILabel>("DesLabel");
        checkBtn_UIButton = root.FindScript<UIButton>("checkBtn");

    }
    #endregion
}