﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for BattleOrderListView.
/// </summary>
public partial class BattleOrderListView : BaseView
{
	public const string NAME ="BattleOrderListView";
	public UIGrid itemGrid;
	public UISprite ContentBg;
	public UIEventTrigger BgCollider_UIEventTrigger;

	protected override void InitElementBinding ()
    {
        var root = this.gameObject.transform;
		itemGrid = root.Find("ContentBg/itemGrid").GetComponent<UIGrid>();
		ContentBg = root.Find("ContentBg").GetComponent<UISprite>();
		BgCollider_UIEventTrigger = root.Find("BgCollider").GetComponent<UIEventTrigger>();
	}
}