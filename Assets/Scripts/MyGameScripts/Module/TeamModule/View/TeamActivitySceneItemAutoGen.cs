﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class TeamActivitySceneItem : BaseView
{
    public const string NAME ="TeamActivitySceneItem";

    #region Element Bindings

    /// bind gameobject
    public UIButton TeamActivitySceneItem_UIButton;
    public UILabel Name_UILabel;
    public UISprite Icon_UISprite;
    public UISprite Item_UISprite;
    public GameObject Select;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        TeamActivitySceneItem_UIButton = root.FindScript<UIButton>("");
        Name_UILabel = root.FindScript<UILabel>("Name");
        Icon_UISprite = root.FindScript<UISprite>("Icon");
        Item_UISprite = root.FindScript<UISprite>("");
        Select = root.FindGameObject("Select");

    }
    #endregion
}
