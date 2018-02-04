﻿// **********************************************************************
// Copyright (c) 2016 Baoyugame. All rights reserved.
// Author : xush
// Created : 7/2/2017 11:49:49 AM
// Desc	: Auto generated by MarsZ. update this if need.
// **********************************************************************

using AppDto;
using UnityEngine;
 /// <summary>
 /// This is the proxy class for module BaseWinController, use this to show or hide this module.
 /// @xush in 7/2/2017 11:49:49 AM
 /// </summary>
public static class ProxyBaseWinModule
 {
     private static UILayerType _layer;
	public static IBaseTipWindowController Open(UILayerType layer = UILayerType.ThreeModule)
	{
	    _layer = layer;
        var controller = BaseTipWindowController.Show<BaseTipWindowController>(
			BaseTipWindow.NAME,
            layer,
			true);
	    return controller;
	}

	public static void Hide()
	{
        UIModuleManager.Instance.HideModule(BaseTipWindow.NAME);	
	}
	
	public static void Close()
	{
        UIModuleManager.Instance.CloseModule(BaseTipWindow.NAME);
        //如果弹窗队列中还有其他弹窗,则在1s之后弹出下一个
	    if (BaseTipWindowController.TipWinList.Count > 0)
	    {
            JSTimer.Instance.SetupCoolDown("ProxyBaseWinModule", 1f, null, () =>
            {
                var tip = BaseTipWindowController.TipWinList[0];
                BaseTipWindowController.TipWinList.RemoveAt(0);
                BaseTipWindowController.SetWinState = false;
                var controller = Open(_layer);
                if (tip is TeamInvitationNotify)
                    controller.InitView(tip as TeamInvitationNotify);
                else if (tip is TeamRequestNotify)
                    controller.InitView(tip as TeamRequestNotify, true);
                else if (tip is CallMemberNotify)
                    controller.InitView(tip as CallMemberNotify);
                else if (tip is BaseTipData)
                    controller.InitView(tip as BaseTipData);
            });
        }else
            BaseTipWindowController.SetWinState = false;
    }
}