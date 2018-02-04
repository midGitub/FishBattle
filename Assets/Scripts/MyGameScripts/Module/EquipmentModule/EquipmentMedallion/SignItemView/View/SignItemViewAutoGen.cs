﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public partial class SignItemView : BaseView
{
    public const string NAME ="SignItemView";

    #region Element Bindings

    /// bind gameobject
    public UILabel Name_UILabel;
    public UILabel NotUse_UILabel;
    public UITable Tabel_UITable;
    public GameObject Item_UIWidget;
    public GameObject IconAnchor;
    public UIButton ItemBg_UIButton;
    public UISprite BgSprite_UISprite;
    public UISprite DisableBg_UISprite;
    public UILabel Props_UILable;
    public UISprite Item_1_UISprite;
    public UISprite Item_2_UISprite;
    public UISprite Item_3_UISprite;
    public UISprite Item_4_UISprite;
    public UISprite Item_5_UISprite;
    public UISprite AddIcon_UISprite;
    public UIButton AddIcon_UIButton;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        Name_UILabel = root.FindScript<UILabel>("Bg/Item/Name");
        NotUse_UILabel = root.FindScript<UILabel>("Bg/Item/NotUse");
        Tabel_UITable = root.FindScript<UITable>("Bg/Item/Tabel");
        Item_UIWidget = root.FindGameObject("Bg/Item");
        IconAnchor = root.FindGameObject("Bg/IconAnchor");
        ItemBg_UIButton = root.FindScript<UIButton>("Bg");
        BgSprite_UISprite = root.FindScript<UISprite>("Bg/BgSprite");
        DisableBg_UISprite = root.FindScript<UISprite>("Bg/DisableBg");
        Props_UILable = root.FindScript<UILabel>("Bg/Item/Props");
        Item_1_UISprite = root.FindScript<UISprite>("Bg/Item/Tabel/Item_1");
        Item_2_UISprite = root.FindScript<UISprite>("Bg/Item/Tabel/Item_2");
        Item_3_UISprite = root.FindScript<UISprite>("Bg/Item/Tabel/Item_3");
        Item_4_UISprite = root.FindScript<UISprite>("Bg/Item/Tabel/Item_4");
        Item_5_UISprite = root.FindScript<UISprite>("Bg/Item/Tabel/Item_5");
        AddIcon_UISprite = root.FindScript<UISprite>("Bg/AddIcon");
        AddIcon_UIButton = root.FindScript<UIButton>("Bg/Item/AddIcon");

    }
    #endregion
}