﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class CrewFavorableView : BaseView
{
    public const string NAME ="CrewFavorableView";

    #region Element Bindings

    /// bind gameobject
    public UILabel DialogLb_UILabel;
    public UISprite Dialog;
    public UILabel FamilyLb_UILabel;
    public UILabel SexLb_UILabel;
    public UILabel CrewNameLb_UILabel;
    public UIButton CloseBtn_UIButton;
    public Transform ModelAnchor_Transform;
    public UITexture Texture_UITexture;
    public UIButton LastBtn_UIButton;
    public UISprite IconSprite_UISprite;
    public UIButton CloseRecordBtn_UIButton;
    public UIPanel RecordPanel_UIPanel;
    public UISprite FavorableSlider_UISprite;
    public UIButton DressBtn_UIButton;
    public UIButton PrefixBtn_UIButton;
    public UIButton BiographyBtn_UIButton;
    public UIButton NextBtn_UIButton;
    public UILabel LvLb_UILabel;
    public UIButton TextureBtn_UIButton;
    public UIButton RecordBtn_UIButton;
    public UIButton HistoryBtn_UIButton;
    public UIButton RewardBtn_UIButton;
    public UIButton TipBtn_UIButton;
    public UIButton ModelBtn_UIButton;
    public UILabel NameLb_UILabel;
    public UILabel AgeLb_UILabel;
    public UILabel ProfessionLb_UILabel;
    public UIScrollView ScrollView_UIScrollView;
    public UILabel RecordDescLb_UILabel;
    public UIPanel HistoryPanel_UIPanel;
    public UIButton CloseHistoryBtn_UIButton;
    public UITable HistoryTable_UITable;
    public UIPanel RewardPanel_UIPanel;
    public UIButton CloseRewardBtn_UIButton;
    public UIScrollView RewardScrollView_UIScrollView;
    public UIGrid RewardGrid_UIGrid;
    public UIScrollView HistoryScrollView_UIScrollView;
    public GameObject ModelAnchor;
    public GameObject BtnGrid;
    public TweenPosition RecordPanel_TweenPosition;
    public UIButton FavorableSlider_UIButton;
    public UILabel SliderValue_UILabel;
    public TweenPosition RewardPanel_TweenPosition;
    public TweenPosition FavorableSlider_TweenPosition;
    public TweenPosition HistoryPanel_TweenPosition;
    public TweenPosition Texture_TweenPosition;
    public TweenPosition ModelAnchor_TweenPosition;
    public TweenRotation Texture_TweenRotation;
    public UIButton Texture_UIButton;
    public UISprite DialogUnder_UISprite;
    public UILabel DialogUnderLb_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        DialogLb_UILabel = root.FindScript<UILabel>("Dialog/DialogLb");
        Dialog = root.FindScript<UISprite>("Dialog");
        FamilyLb_UILabel = root.FindScript<UILabel>("RecordPanel/FamilyLb");
        SexLb_UILabel = root.FindScript<UILabel>("RecordPanel/SexLb");
        CrewNameLb_UILabel = root.FindScript<UILabel>("RecordPanel/CrewNameLb");
        CloseBtn_UIButton = root.FindScript<UIButton>("CloseBtn");
        ModelAnchor_Transform = root.FindTrans("ModelAnchor");
        Texture_UITexture = root.FindScript<UITexture>("Texture");
        LastBtn_UIButton = root.FindScript<UIButton>("LastBtn");
        IconSprite_UISprite = root.FindScript<UISprite>("RecordPanel/IconSprite");
        CloseRecordBtn_UIButton = root.FindScript<UIButton>("RecordPanel/CloseRecordBtn");
        RecordPanel_UIPanel = root.FindScript<UIPanel>("RecordPanel");
        FavorableSlider_UISprite = root.FindScript<UISprite>("FavorableSlider");
        DressBtn_UIButton = root.FindScript<UIButton>("BtnGrid/DressBtn");
        PrefixBtn_UIButton = root.FindScript<UIButton>("BtnGrid/PrefixBtn");
        BiographyBtn_UIButton = root.FindScript<UIButton>("BtnGrid/BiographyBtn");
        NextBtn_UIButton = root.FindScript<UIButton>("NextBtn");
        LvLb_UILabel = root.FindScript<UILabel>("FavorableSlider/LvLb");
        TextureBtn_UIButton = root.FindScript<UIButton>("TextureBtn");
        RecordBtn_UIButton = root.FindScript<UIButton>("BtnGrid/RecordBtn");
        HistoryBtn_UIButton = root.FindScript<UIButton>("BtnGrid/HistoryBtn");
        RewardBtn_UIButton = root.FindScript<UIButton>("BtnGrid/RewardBtn");
        TipBtn_UIButton = root.FindScript<UIButton>("TipBtn");
        ModelBtn_UIButton = root.FindScript<UIButton>("ModelBtn");
        NameLb_UILabel = root.FindScript<UILabel>("NameLb");
        AgeLb_UILabel = root.FindScript<UILabel>("RecordPanel/AgeLb");
        ProfessionLb_UILabel = root.FindScript<UILabel>("RecordPanel/ProfessionLb");
        ScrollView_UIScrollView = root.FindScript<UIScrollView>("RecordPanel/ScrollView");
        RecordDescLb_UILabel = root.FindScript<UILabel>("RecordPanel/ScrollView/RecordDescLb");
        HistoryPanel_UIPanel = root.FindScript<UIPanel>("HistoryPanel");
        CloseHistoryBtn_UIButton = root.FindScript<UIButton>("HistoryPanel/CloseHistoryBtn");
        HistoryTable_UITable = root.FindScript<UITable>("HistoryPanel/HistoryScrollView/HistoryTable");
        RewardPanel_UIPanel = root.FindScript<UIPanel>("RewardPanel");
        CloseRewardBtn_UIButton = root.FindScript<UIButton>("RewardPanel/CloseRewardBtn");
        RewardScrollView_UIScrollView = root.FindScript<UIScrollView>("RewardPanel/RewardScrollView");
        RewardGrid_UIGrid = root.FindScript<UIGrid>("RewardPanel/RewardScrollView/RewardGrid");
        HistoryScrollView_UIScrollView = root.FindScript<UIScrollView>("HistoryPanel/HistoryScrollView");
        ModelAnchor = root.FindGameObject("ModelAnchor");
        BtnGrid = root.FindGameObject("BtnGrid");
        RecordPanel_TweenPosition = root.FindScript<TweenPosition>("RecordPanel");
        FavorableSlider_UIButton = root.FindScript<UIButton>("FavorableSlider");
        SliderValue_UILabel = root.FindScript<UILabel>("FavorableSlider/SliderValue");
        RewardPanel_TweenPosition = root.FindScript<TweenPosition>("RewardPanel");
        FavorableSlider_TweenPosition = root.FindScript<TweenPosition>("FavorableSlider");
        HistoryPanel_TweenPosition = root.FindScript<TweenPosition>("HistoryPanel");
        Texture_TweenPosition = root.FindScript<TweenPosition>("Texture");
        ModelAnchor_TweenPosition = root.FindScript<TweenPosition>("ModelAnchor");
        Texture_TweenRotation = root.FindScript<TweenRotation>("Texture");
        Texture_UIButton = root.FindScript<UIButton>("Texture");
        DialogUnder_UISprite = root.FindScript<UISprite>("DialogUnder");
        DialogUnderLb_UILabel = root.FindScript<UILabel>("DialogUnder/DialogUnderLb");

    }
    #endregion
}