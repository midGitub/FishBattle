﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : Xianjian
// Created : 10/8/2016 2:29:23 PM
// Desc	: Auto generated by MarsZ. update this if need.
// **********************************************************************

using UnityEngine;
using SdkAccountDto;


public class SdkBindController : MonoViewController<SdkBindView>
{
    protected override void RegistCustomEvent()
    {
        EventDelegate.Set(_view.BackBtn.onClick, () => { SdkProxyModule.CloseModuleSlow(SdkBindView.NAME); });
        EventDelegate.Set(_view.PhoneBtn.onClick, OnPhoneBtn);
        EventDelegate.Set(_view.WeixinBtn.onClick, OnWeixinBtn);
        EventDelegate.Set(_view.QQBtn.onClick, OnQQBtn);
    }

    public void OnPhoneBtn()
    {
        var com = SdkProxyModule.OpenModule<SdkBindCodeController>(SdkBindCodeView.NAME, SdkModuleMgr.ModuleType.preLogin);
        com.InitData("账号绑定", AccountDto.AccountType.phone);
    }

    public void OnWeixinBtn()
    {
        ;
    }

    public void OnQQBtn()
    {

    }
}