﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class MiniWorldMapView : BaseView
{
    public const string NAME ="MiniWorldMapView";

    #region Element Bindings

    /// bind gameobject
    public GameObject CloseBtn;
    public GameObject PlaceGroup;
    public GameObject CurrMapBtn;
    public GameObject HeroSprite;
    public UISprite PlayerHeadSprite;
    public UISprite EffPos;
    public UITexture Map_UITexture;
    public UIButton CloseBtn_UIButton;
    public UIButton CurrMapBtn_UIButton;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        CloseBtn = root.FindGameObject("CloseBtn");
        PlaceGroup = root.FindGameObject("PlaceGroup");
        CurrMapBtn = root.FindGameObject("CurrMapBtn");
        HeroSprite = root.FindGameObject("HeroSprite");
        PlayerHeadSprite = root.FindScript<UISprite>("HeroSprite/PlayerHeadSprite");
        EffPos = root.FindScript<UISprite>("HeroSprite/Sprite");
        Map_UITexture = root.FindScript<UITexture>("Texture");
        CloseBtn_UIButton = root.FindScript<UIButton>("CloseBtn");
        CurrMapBtn_UIButton = root.FindScript<UIButton>("CurrMapBtn");

    }
    #endregion
}