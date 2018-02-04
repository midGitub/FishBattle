﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;


/// <summary>
/// Generates a safe wrapper for _ModuleName_View.
/// </summary>
public partial class RoleSkillTalentSingleItem : BaseView
{
    public const string NAME ="RoleSkillTalentSingleItem";

    #region Element Bindings

    /// bind gameobject
    public UISprite bg_UISprite;
    public UISprite spIcon_UISprite;
    public UISprite spSelected_UISprite;
    public UILabel lblName_UILabel;
    public UILabel lblNum_UILabel;
    public UISprite arrow_UISprite;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        bg_UISprite = root.FindScript<UISprite>("bg");
        spIcon_UISprite = root.FindScript<UISprite>("spIcon");
        spSelected_UISprite = root.FindScript<UISprite>("spSelected");
        lblName_UILabel = root.FindScript<UILabel>("lblName");
        lblNum_UILabel = root.FindScript<UILabel>("lblNum");
        arrow_UISprite = root.FindScript<UISprite>("arrow");
    }
    #endregion
}

