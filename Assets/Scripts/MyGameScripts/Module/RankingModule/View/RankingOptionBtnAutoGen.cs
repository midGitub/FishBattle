﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class RankingOptionBtn : BaseView
{
    public const string NAME ="RankingOptionBtn";

    #region Element Bindings

    /// bind gameobject
    public UILabel BtnNameLb_UILabel;
    public UIButton RankingOptionBtn_UIButton;
    public GameObject Select;
    public UISprite Arrow_UISprite;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        BtnNameLb_UILabel = root.FindScript<UILabel>("BtnNameLb");
        RankingOptionBtn_UIButton = root.FindScript<UIButton>("");
        Select = root.FindGameObject("Select");
        Arrow_UISprite = root.FindScript<UISprite>("Arrow");

    }
    #endregion
}
