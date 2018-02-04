﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class ChatAtItem : BaseView
{
    public const string NAME ="ChatAtItem";

    #region Element Bindings

    /// bind gameobject
    public UIButton icon_UIButton;
    public UISprite icon_UISprite;
    public UILabel Name_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        icon_UIButton = root.FindScript<UIButton>("Bg");
        icon_UISprite = root.FindScript<UISprite>("icon");
        Name_UILabel = root.FindScript<UILabel>("Name");

    }
    #endregion
}
