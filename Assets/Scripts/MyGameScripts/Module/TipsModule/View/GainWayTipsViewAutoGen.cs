﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class GainWayTipsView : BaseView
{
    public const string NAME ="GainWayTipsView";

    #region Element Bindings

    /// bind gameobject
    public Transform Pos_Transform;
    public UIScrollView ScrollView_UIScrollView;
    public UIGrid ItemGrid_UIGrid;
    public UIPanel GainWayTipsView_UIPanel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        Pos_Transform = root.FindTrans("Pos");
        ScrollView_UIScrollView = root.FindScript<UIScrollView>("Pos/ScrollView");
        ItemGrid_UIGrid = root.FindScript<UIGrid>("Pos/ScrollView/ItemGrid");
        GainWayTipsView_UIPanel = root.FindScript<UIPanel>("");

    }
    #endregion
}
