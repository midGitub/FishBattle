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
public partial class _ModuleName_View : BaseView
{
    public const string NAME ="_ModuleName_View";

	public UISprite Sprite22_UISprite;
	public UILabel Label11_UILabel;
	public UITexture Texture33_UITexture;
	public UILabel Label44_UILabel;
	public UISprite Sprite55_UISprite;
	public Transform CntrMain_Transform;

	protected override void InitElementBinding ()
    {
        var root = this.gameObject.transform;
		Sprite22_UISprite = root.Find("CntrMain/Sprite22").GetComponent<UISprite>();
		Label11_UILabel = root.Find("CntrMain/Label11").GetComponent<UILabel>();
		Texture33_UITexture = root.Find("CntrMain/Texture33").GetComponent<UITexture>();
		Label44_UILabel = root.Find("CntrMain/Label44").GetComponent<UILabel>();
		Sprite55_UISprite = root.Find("CntrMain/Label44/Sprite55").GetComponent<UISprite>();
		CntrMain_Transform = root.Find("CntrMain");
	}
}