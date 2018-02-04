﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for SdkModifyPasswordConfirmView.
/// </summary>
public partial class SdkModifyPasswordConfirmView : BaseView
{
	public const string NAME ="SdkModifyPasswordConfirmView";
	public UIInput CodeInput;
	public UIInput PasswordInput1;
	public UIInput PasswordInput2;
	public UIButton ConfirmBtn;
	public UIButton GetCodeBtn;
	public UIButton BackBtn;
	public UILabel SendCodeLbl;

	protected override void InitElementBinding ()
    {
        var root = this.gameObject.transform;
		CodeInput = root.Find("CodeInput").GetComponent<UIInput>();
		PasswordInput1 = root.Find("PasswordInput1").GetComponent<UIInput>();
		PasswordInput2 = root.Find("PasswordInput2").GetComponent<UIInput>();
		ConfirmBtn = root.Find("ConfirmBtn").GetComponent<UIButton>();
		GetCodeBtn = root.Find("GetCodeBtn").GetComponent<UIButton>();
		BackBtn = root.Find("BackBtn").GetComponent<UIButton>();
		SendCodeLbl = root.Find("GetCodeBtn/Label").GetComponent<UILabel>();
	}
}
