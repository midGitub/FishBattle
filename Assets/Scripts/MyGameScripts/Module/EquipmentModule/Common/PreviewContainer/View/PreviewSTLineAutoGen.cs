﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class PreviewSTLine : BaseView
{
    public const string NAME ="PreviewSTLine";

    #region Element Bindings

    /// bind gameobject
    public UILabel NameLbl_UILabel;
    public Transform IconItems_Transform;
    public UIWidget PreviewSTLine_UIWidget;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        NameLbl_UILabel = root.FindScript<UILabel>("NameLbl");
        IconItems_Transform = root.FindTrans("IconItems");
        PreviewSTLine_UIWidget = root.FindScript<UIWidget>("");

    }
    #endregion
}
