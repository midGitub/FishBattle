﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for SkillButtonCell.
/// </summary>
public partial class SkillButtonCell : BaseView
{
	public const string NAME ="SkillButtonCell";
	public UIWidget SkillIconGroup_UIWidget;
	public GameObject SkillIconGroup;
	public UILabel NameLabel_UILabel;
	public UISprite SkillIcon_UISprite;
	public UIButton SkillButtonCell_UIButton;
	public ButtonLabelSpacingAdjust SkillIconGroup_ButtonLabelSpacingAdjust;
	public UILabel LabelCD_UILabel;
	public GameObject SpriteSelected;
	public GameObject CntrPoint;
	public UILabel LabelPoint_UILabel;
	public UISprite SkillMask_UISprite;
	public GameObject CntrCD;
	public UISprite SkillSprite_UISprite;
	public Transform NamePositionCenterDown_Transform;
	public Transform NamePositionDown_Transform;
	public UIDragScrollView SkillButtonCell_UIDragScrollView;
	public GameObject CntrSubscript;
	public UISprite SpriteSuper_UISprite;
	public GameObject EnableEffect;
	public TweenAlpha EnableEffect_TweenAlpha;

	protected override void InitElementBinding ()
	{
		var root = this.gameObject.transform;
		SkillIconGroup_UIWidget = root.Find("SkillIconGroup").GetComponent<UIWidget>();
		SkillIconGroup = root.Find("SkillIconGroup").gameObject;
		NameLabel_UILabel = root.Find("SkillIconGroup/NamePositionCenterDown/NameLabel").GetComponent<UILabel>();
		SkillIcon_UISprite = root.Find("SkillIconGroup/SkillIcon").GetComponent<UISprite>();
	SkillButtonCell_UIButton = root.GetComponent<UIButton>();
		SkillIconGroup_ButtonLabelSpacingAdjust = root.Find("SkillIconGroup").GetComponent<ButtonLabelSpacingAdjust>();
		LabelCD_UILabel = root.Find("SkillIconGroup/CntrCD/LabelCD").GetComponent<UILabel>();
		SpriteSelected = root.Find("SkillIconGroup/SpriteSelected").gameObject;
		CntrPoint = root.Find("SkillIconGroup/CntrPoint").gameObject;
		LabelPoint_UILabel = root.Find("SkillIconGroup/CntrPoint/LabelPoint").GetComponent<UILabel>();
		SkillMask_UISprite = root.Find("SkillIconGroup/CntrCD/SkillMask").GetComponent<UISprite>();
		CntrCD = root.Find("SkillIconGroup/CntrCD").gameObject;
		SkillSprite_UISprite = root.Find("SkillIconGroup/SkillSprite").GetComponent<UISprite>();
		NamePositionCenterDown_Transform = root.Find("SkillIconGroup/NamePositionCenterDown");
		NamePositionDown_Transform = root.Find("SkillIconGroup/NamePositionDown");
	SkillButtonCell_UIDragScrollView = root.GetComponent<UIDragScrollView>();
		CntrSubscript = root.Find("SkillIconGroup/CntrSubscript").gameObject;
		SpriteSuper_UISprite = root.Find("SkillIconGroup/CntrSubscript/SpriteSuper").GetComponent<UISprite>();
		EnableEffect = root.Find("SkillIconGroup/CntrEnableEffect/EnableEffect").gameObject;
		EnableEffect_TweenAlpha = root.Find("SkillIconGroup/CntrEnableEffect/EnableEffect").GetComponent<TweenAlpha>();
	}
}
