﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class RankingPage : BaseView
{
    public const string NAME ="RankingPage";

    #region Element Bindings

    /// bind gameobject
    public UITable SecondTable_UITable;
    public UITable OptionTable_UITable;
    public UIRecycledList SimpleRankingGrid_UIRecycledList;
    public UIRecycledList AppellationRankingGrid_UIRecycledList;
    public Transform FirstPrizeAnchor_Transform;
    public Transform SecondPrizeAnchor_Transform;
    public Transform ThirdPrizeAnchor_Transform;
    public GameObject SimpleRankingPageUI;
    public GameObject AppellationRankingPageUI;
    public UIScrollView SimpleRankingUIScrollView_UIScrollView;
    public UIScrollView AppellationRankingScrollView_UIScrollView;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        SecondTable_UITable = root.FindScript<UITable>("MenuGroup/SecondTable");
        OptionTable_UITable = root.FindScript<UITable>("MenuGroup/MenuScollView/OptionTable");
        SimpleRankingGrid_UIRecycledList = root.FindScript<UIRecycledList>("SimpleRankingPageUI/SimpleRankingUIScrollView/SimpleRankingGrid");
        AppellationRankingGrid_UIRecycledList = root.FindScript<UIRecycledList>("AppellationRankingPageUI/AppellationRankingScrollView/AppellationRankingGrid");
        FirstPrizeAnchor_Transform = root.FindTrans("AppellationRankingPageUI/AppellationCard/FirstPrizeAnchor");
        SecondPrizeAnchor_Transform = root.FindTrans("AppellationRankingPageUI/AppellationCard/SecondPrizeAnchor");
        ThirdPrizeAnchor_Transform = root.FindTrans("AppellationRankingPageUI/AppellationCard/ThirdPrizeAnchor");
        SimpleRankingPageUI = root.FindGameObject("SimpleRankingPageUI");
        AppellationRankingPageUI = root.FindGameObject("AppellationRankingPageUI");
        SimpleRankingUIScrollView_UIScrollView = root.FindScript<UIScrollView>("SimpleRankingPageUI/SimpleRankingUIScrollView");
        AppellationRankingScrollView_UIScrollView = root.FindScript<UIScrollView>("AppellationRankingPageUI/AppellationRankingScrollView");

    }
    #endregion
}
