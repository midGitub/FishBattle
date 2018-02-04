﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class CrewFormationCaseItem : BaseView
{
    public const string NAME ="CrewFormationCaseItem";

    #region Element Bindings

    /// bind gameobject
    public GameObject GenericCheckBox;
    public GameObject Select;
    public UISprite Checkmark_UISprite;
    public UIButton FormationBtn_UIButton;
    public UILabel FormationName_UILabel;
    public UIButton CrewFormationCaseItem_UIButton;
    public UILabel CaseName_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        GenericCheckBox = root.FindGameObject("GenericCheckBox");
        Select = root.FindGameObject("Select");
        Checkmark_UISprite = root.FindScript<UISprite>("GenericCheckBox/Checkmark");
        FormationBtn_UIButton = root.FindScript<UIButton>("FormationBtn");
        FormationName_UILabel = root.FindScript<UILabel>("FormationBtn/FormationName");
        CrewFormationCaseItem_UIButton = root.FindScript<UIButton>("");
        CaseName_UILabel = root.FindScript<UILabel>("GenericCheckBox/CaseName");

    }
    #endregion
}
