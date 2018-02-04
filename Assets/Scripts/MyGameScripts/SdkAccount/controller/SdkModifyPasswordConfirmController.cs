﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : Xianjian
// Created : 9/29/2016 5:19:03 PM
// Desc	: Auto generated by MarsZ. update this if need.
// **********************************************************************

using UnityEngine;

 /// <summary>
 /// This is the controller class for module FindPasswordConfirm, use this to control the ui or view , such as it's init , update or dispose.
 /// @Xianjian in 9/29/2016 5:19:03 PM
 /// </summary>
public class SdkModifyPasswordConfirmController : MonoViewController<SdkModifyPasswordConfirmView>
{

    private string _phone;

    public string Phone {
        set { _phone = value; }
        get { return _phone; }
    }

     public void InitData(string phone)
     {
         Phone = phone;
         StartCodeLimit();
     }

    protected override void RegistCustomEvent()
    {
        EventDelegate.Set(_view.BackBtn.onClick, () => { SdkProxyModule.CloseModuleSlow(SdkModifyPasswordConfirmView.NAME); });
        EventDelegate.Set(_view.ConfirmBtn.onClick, OnConfirm);
        EventDelegate.Set(_view.GetCodeBtn.onClick, OnReSendCode);
    }

    public void OnConfirm()
    {
        string code = _view.CodeInput.value;
        string psd1 = _view.PasswordInput1.value;
        string psd2 = _view.PasswordInput2.value;
        if (!SdkAccountModel.CheckVerifyCode(code) ||
            !SdkAccountModel.CheckPassword(psd1, psd2)
            )
        {
            return;
        }

        string password = MD5Hashing.HashString(psd1);
        string sid = SdkAccountModel.Instance.GetSid();
        SdkService.RequestModifyPassword(sid, password,
            code, (backcode) =>
            {
                if (backcode == 0)
                {
                    SdkProxyModule.OpenGameCenter();
                    GameDebuger.Log("修改密码成功");
                }
            });
    }

    public void OnReSendCode()
    {
        SdkService.RequestPhoneCode(_phone, (backcode) =>
        {
            if (backcode == 0)
            {
                if (BaseView.IsViewDestroy(View))
                    return;

                StartCodeLimit();
                GameDebuger.Log("重发验证码成功");
            }
        });
    }

    public void StartCodeLimit()
    {
        _view.GetCodeBtn.GetComponent<BoxCollider>().enabled = false;
        _view.GetCodeBtn.SetState(UIButtonColor.State.Disabled, true);

        CSTimer.Instance.SetupCoolDown("SdkModifyPasswordCode", SdkAccountModel.CODE_LIMIT_SEC, OnLimitUpdate, OnLimitFinish);
    }

    public void OnLimitUpdate(float remainSec)
    {
        _view.SendCodeLbl.text = string.Format("{0}秒", Mathf.Ceil(remainSec));
    }

    public void OnLimitFinish()
    {
        _view.SendCodeLbl.text = "重发验证码";
        _view.GetCodeBtn.GetComponent<BoxCollider>().enabled = true;
        _view.GetCodeBtn.SetState(UIButtonColor.State.Normal, true);
    }

    protected override void OnDispose()
    {
        CSTimer.Instance.CancelCd("SdkModifyPasswordCode");
    }

}