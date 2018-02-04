﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for BattleAutoSkillConfigView.
/// </summary>
public partial class BattleAutoSkillConfigView : BaseView
{
	public const string NAME ="BattleAutoSkillConfigView";
	public UIButton BtnClose_UIButton;
	public GameObject CurrentSkillIcon;
	public UILabel LabelSkillName_UILabel;
	public UILabel LabelSkillCost_UILabel;
	
	public UILabel LabelSkillDesc_UILabel;
	public UIScrollView ScrollViewSkillList_UIScrollView;
	public UIGrid GridSkillList_UIGrid;

	protected override void InitElementBinding ()
	{
		var root = this.gameObject.transform;
		BtnClose_UIButton = root.Find("CntrMain/CntrBG/BtnClose").GetComponent<UIButton>();
		CurrentSkillIcon = root.Find("CntrMain/CntrCurrent/CntrCurrentInfo/CurrentSkillIcon").gameObject;
		LabelSkillName_UILabel = root.Find("CntrMain/CntrCurrent/CntrCurrentInfo/LabelSkillName").GetComponent<UILabel>();
		LabelSkillCost_UILabel = root.Find("CntrMain/CntrCurrent/CntrCurrentInfo/LabelSkillCost").GetComponent<UILabel>();
		LabelSkillDesc_UILabel = root.Find("CntrMain/CntrCurrent/CntrCurrentInfo/LabelSkillDesc").GetComponent<UILabel>();
		ScrollViewSkillList_UIScrollView = root.Find("CntrMain/CntrList/ScrollViewSkillList").GetComponent<UIScrollView>();
		GridSkillList_UIGrid = root.Find("CntrMain/CntrList/ScrollViewSkillList/GridSkillList").GetComponent<UIGrid>();
	}
}