﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class RecordEvtItem : BaseView
{
    public const string NAME ="RecordEvtItem";

    #region Element Bindings

    /// bind gameobject
    public UIButton RecordEvtItem_UIButton;
    public UISprite RecordEvtItem_UISprite;
    public UILabel lbltype_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        RecordEvtItem_UIButton = root.FindScript<UIButton>("");
        RecordEvtItem_UISprite = root.FindScript<UISprite>("");
        lbltype_UILabel = root.FindScript<UILabel>("lbltype");

    }
    #endregion
}
