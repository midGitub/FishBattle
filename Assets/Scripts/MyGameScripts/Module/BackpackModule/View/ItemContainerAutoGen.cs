﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for _ModuleName_View.
/// </summary>
public partial class ItemContainer : BaseView
{
    public const string NAME ="ItemContainer";

    #region Element Bindings

    /// bind gameobject
        public UIGrid GridGroup_UIGrid;
    public UIPageInfo ItemContainer_UIPageInfo;
    public UIDragScrollView ItemContainer_UIDragScrollView;


    protected override void InitElementBinding ()
    {
	var root = this.gameObject;
                GridGroup_UIGrid = root.FindScript<UIGrid>("GridGroup");
        ItemContainer_UIPageInfo = root.FindScript<UIPageInfo>("");
        ItemContainer_UIDragScrollView = root.FindScript<UIDragScrollView>("");

    }
    #endregion
}

