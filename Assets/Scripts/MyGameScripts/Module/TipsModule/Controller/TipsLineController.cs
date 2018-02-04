﻿// **********************************************************************
// Copyright (c)  Baoyugame. All rights reserved.
// File     :  TipsLineController.cs
// Author   : 
// Created  : $timeDecls$
// Porpuse  : 
// **********************************************************************

using System;

public partial class TipsLineController
{
    // 界面初始化完成之后的一些后续初始化工作
    protected override void AfterInitView ()
    {
 
    }

    // 客户端自定义事件
    protected override void RegistCustomEvent ()
    {

    }

    protected override void OnDispose()
    {

    }

    // 如果自定义客户端交互使用了事件流，还是需要remove的
    protected override void RemoveCustomEvent ()
    {
        
    }

    public void SetLineOrSpace(bool isLine)
    {
        if(isLine)
            View.Sprite_UISprite.alpha = 1;
        else
            View.Sprite_UISprite.alpha = 0;
    }
}
