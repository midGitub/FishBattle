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
public partial class EmojiItem : BaseView
{
    public const string NAME ="EmojiItem";

    #region Element Bindings
    public UISpriteAnimation _spriteAnimator;
    public UIButton _button;
    /// bind gameobject
    

    protected override void InitElementBinding ()
    {
	var root = this.gameObject;
        _spriteAnimator = root.GetComponent<UISpriteAnimation>();
        _button = root.GetComponent<UIButton>();
    }
    #endregion
}
