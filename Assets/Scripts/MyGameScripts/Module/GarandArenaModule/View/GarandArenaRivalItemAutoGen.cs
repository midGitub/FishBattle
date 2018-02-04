﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed class GarandArenaRivalItem : BaseView
{
    public const string NAME ="GarandArenaRivalItem";

    #region Element Bindings

    /// bind gameobject
    public UISprite PlayerIcon_UISprite;
    public UILabel Lv_UILabel;
    public UISprite Magic_UISprite;
    public UISprite Faction_UISprite;
    public UILabel CupNum_UILabel;
    public UIButton ChallengeBtn_UIButton;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        PlayerIcon_UISprite = root.FindScript<UISprite>("PlayerIcon");
        Lv_UILabel = root.FindScript<UILabel>("PlayerIcon/Lv");
        Magic_UISprite = root.FindScript<UISprite>("Magic");
        Faction_UISprite = root.FindScript<UISprite>("Magic/Faction");
        CupNum_UILabel = root.FindScript<UILabel>("CupNum");
        ChallengeBtn_UIButton = root.FindScript<UIButton>("ChallengeBtn");

    }
    #endregion
}
