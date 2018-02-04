﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for ServerRoleItem.
/// </summary>
public partial class ServerRoleItem : BaseView
{
	public UISprite RoleIconSprite_UISprite;
	public UILabel NameLabel_UILabel;
	public UIButton DelButton_UIButton;
	public GameObject AddRoleISprite;
	public UIButton BgSprite_UIButton;
	public UISprite BgSprite_UISprite;
	public UILabel FactionLabel_UILabel;
	public UILabel LvLabel_UILabel;
	public GameObject DelTipSprite;
	public UIEventTrigger BgSprite_UIEventTrigger;
	public UIEventTrigger DelButton_UIEventTrigger;
    public GameObject SelSp_Go;

	protected override void InitElementBinding ()
    {
        var root = this.gameObject.transform;
		RoleIconSprite_UISprite = root.Find("IconBgSprite/RoleIconSprite").GetComponent<UISprite>();
		NameLabel_UILabel = root.Find("NameLabel").GetComponent<UILabel>();
		DelButton_UIButton = root.Find("DelButton").GetComponent<UIButton>();
		AddRoleISprite = root.Find("IconBgSprite/AddRoleISprite").gameObject;
		BgSprite_UIButton = root.Find("BgSprite").GetComponent<UIButton>();
		BgSprite_UISprite = root.Find("BgSprite").GetComponent<UISprite>();
		FactionLabel_UILabel = root.Find("FactionLabel").GetComponent<UILabel>();
		LvLabel_UILabel = root.Find("IconBgSprite/LvLabel").GetComponent<UILabel>();
		DelTipSprite = root.Find("IconBgSprite/DelTipSprite").gameObject;
		BgSprite_UIEventTrigger = root.Find("BgSprite").GetComponent<UIEventTrigger>();
		DelButton_UIEventTrigger = root.Find("DelButton").GetComponent<UIEventTrigger>();
        SelSp_Go = root.Find("SelSp").gameObject;

    }
}