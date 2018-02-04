﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for SkillTipsView.
/// </summary>
public partial class SkillTipsView : BaseView
{
	public const string NAME ="SkillTipsView";
	public UISprite IconSprite;
	public UILabel NameLabel;
	public UILabel SkillDescriptionLbl;
	public UISprite ContentBg;
	public UIAnchor posAnchor;
	public UILabel ExtLabel;

    

	protected override void InitElementBinding ()
	{
		var root = this.gameObject.transform;
		IconSprite = root.Find("ContentBg/TopGroup/IconSprite").GetComponent<UISprite>();
		NameLabel = root.Find("ContentBg/TopGroup/NameLabel").GetComponent<UILabel>();
		SkillDescriptionLbl = root.Find("ContentBg/SkillDescriptionLbl").GetComponent<UILabel>();
		ContentBg = root.Find("ContentBg").GetComponent<UISprite>();
		posAnchor = root.Find("ContentBg").GetComponent<UIAnchor>();
		ExtLabel = root.Find("ContentBg/TopGroup/ExtLabel").GetComponent<UILabel>();


	}
}