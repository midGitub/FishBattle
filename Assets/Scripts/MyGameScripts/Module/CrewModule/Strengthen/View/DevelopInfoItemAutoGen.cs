﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
using AppDto;
using MyGameScripts.Gameplay.Player;
using System.Collections.Generic;
using System;

/// <summary>
/// Generates a safe wrapper for DevelopInfoItem.
/// </summary>
public partial class DevelopInfoItem : BaseView
{
	public const string NAME ="DevelopInfoItem";
	public UILabel BeforeLabel_UILabel;
	public UILabel AfterLabel_UILabel;
    public UILabel beforeLb_UILabel;


    protected override void InitElementBinding ()
	{
		var root = this.gameObject.transform;
		BeforeLabel_UILabel = root.Find("BeforeLabel").GetComponent<UILabel>();
		AfterLabel_UILabel = root.Find("AfterLabel").GetComponent<UILabel>();
        beforeLb_UILabel = root.Find("beforeLb").GetComponent<UILabel>();

    }
}

public partial class DevelopInfoItemController : MonolessViewController<DevelopInfoItem>
{
    //进阶
    public void SetInfo(CharacterPropertyDto dto,CharacterPropertyDto _dto)
    {
        View.BeforeLabel_UILabel.text = GlobalAttr.ATTRNAMES[dto.propId];
        View.beforeLb_UILabel.text = _dto.propValue.ToString().Substring(0, _dto.propValue.ToString().IndexOf(".") + 2);
        View.AfterLabel_UILabel.text = dto.propValue.ToString().Substring(0, dto.propValue.ToString().IndexOf(".") + 2);
    }

    //进阶
    public void SetBestInfo(int id,float value)
    {
        _view.BeforeLabel_UILabel.text = GlobalAttr.ATTRNAMES[id];
        View.beforeLb_UILabel.text = Mathf.Floor(value).ToString();

        _view.AfterLabel_UILabel.text = View.beforeLb_UILabel.text;
    }

    public void SetCombatInfo(float beforePower,float afterPower)
    {
        _view.BeforeLabel_UILabel.text = "战力";
        _view.beforeLb_UILabel.text = beforePower.ToString();
        _view.AfterLabel_UILabel.text = afterPower.ToString();
    }

    public void SetStrengthenInfo(CrewRaise data, CrewRaise _data)
    {
        _view.BeforeLabel_UILabel.text = "基础属性";
        _view.beforeLb_UILabel.text = data.ratio.ToString() + "%";
        _view.AfterLabel_UILabel.text = _data.ratio.ToString() + "%";
    }
}
