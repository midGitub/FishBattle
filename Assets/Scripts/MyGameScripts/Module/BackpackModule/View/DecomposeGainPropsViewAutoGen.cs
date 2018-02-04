﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;


/// <summary>
/// Generates a safe wrapper for _ModuleName_View.
/// </summary>
public partial class DecomposeGainPropsView : BaseView
{
    public const string NAME ="DecomposeGainPropsView";

    #region Element Bindings

    /// bind gameobject
    public UITable GainItemGroup_UIGrid;
    public GameObject GainItemGroup;
    public UIButton BgBoxCollider_UIButton;
    public UISprite BgBoxCollider_UISprite;

    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        GainItemGroup_UIGrid = root.FindScript<UITable>("GainItemGroup");
        GainItemGroup = root.FindGameObject("GainItemGroup");
        BgBoxCollider_UIButton = root.FindScript<UIButton>("BaseWindow/BgBoxCollider");
        BgBoxCollider_UISprite = root.FindScript<UISprite>("BaseWindow/BgBoxCollider");
    }
    #endregion
}

