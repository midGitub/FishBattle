﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class MaterailItemView : BaseView
{
    public const string NAME ="MaterailItemView";

    #region Element Bindings

    /// bind gameobject
    public UILabel Label_UILabel;
    public UISprite Icon_UISprite;
    public UILabel Num_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        Label_UILabel = root.FindScript<UILabel>("Label");
        Icon_UISprite = root.FindScript<UISprite>("Icon");
        Num_UILabel = root.FindScript<UILabel>("Num");

    }
    #endregion
}