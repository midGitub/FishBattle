﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for SkillCellPrefab.
/// </summary>
public partial class SkillCellPrefab : BaseView
{
	public const string NAME ="SkillCellPrefab";
	public UILabel NameLabel_UILabel;
	public UILabel TypeLabel_UILabel;
	public UISprite IconSprite_UISprite;
	public UIButton SkillCellPrefab_UIButton;
	public UISprite SkillCellPrefab_UISprite;
	public UISprite SpriteMask_UISprite;

	protected override void InitElementBinding ()
	{
		var root = this.gameObject.transform;
		NameLabel_UILabel = root.Find("NameLabel").GetComponent<UILabel>();
		TypeLabel_UILabel = root.Find("TypeLabel").GetComponent<UILabel>();
		IconSprite_UISprite = root.Find("IconGroup/IconSprite").GetComponent<UISprite>();
	SkillCellPrefab_UIButton = root.GetComponent<UIButton>();
	SkillCellPrefab_UISprite = root.GetComponent<UISprite>();
		SpriteMask_UISprite = root.Find("IconGroup/SpriteMask").GetComponent<UISprite>();
	}
}
