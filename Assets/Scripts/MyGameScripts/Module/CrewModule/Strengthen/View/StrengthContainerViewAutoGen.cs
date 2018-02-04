﻿// ------------------------------------------------------------------------------
//  This code is generated by a tool
// ------------------------------------------------------------------------------

using UnityEngine;

public sealed partial class StrengthContainerView : BaseView
{
    public const string NAME ="StrengthContainerView";

    #region Element Bindings

    /// bind gameobject
    //public UILabel StrengLevelLabel_UILabel;
    public UILabel BeforeStrength_UILabel;
    public UILabel AfterStrength_UILabel;
    public UIGrid StrengthInfoGrid_UIGrid;
    public UIButton CheckBtn_UIButton;
    public UILabel StrengthEffectLabel_UILabel;
    public UIButton StrengthButton_UIButton;
    public Transform StrengthMasAnchor_Transform;
    public UILabel BestStrengthLab_UILabel;
    public UIGrid ProgressGrid_UIGrid;
    public UILabel ColorLab_UILabel;
    public UILabel LevelLab_UILabel;
    public UILabel Label_UILabel;
    public UILabel BeforeLevel_UILabel;
    public UILabel AfterLevel_UILabel;
    public UIGrid InfoGrid_UIGrid;
    public UILabel EffectLabel_UILabel;
    public UIButton TipButton_UIButton;
    public UIGrid ExpendGrid_UIGrid;
    public UIButton DevelopButton_UIButton;
    public UILabel BestDevelopLab_UILabel;
    public UIButton DevelopEffectBtn_UIButton;
    public UISprite StrengthCrewIcon_b_UISprite;
    public UILabel StrengLevelLab_b_UILabel;
    public UISprite strengthCrewIcon_a_UISprite;
    public UILabel StrengLevelLabel_a_UILabel;
    public UISprite DevelopCrewIcon_b_UISprite;
    public UILabel DevCrewLevel_b_UILabel;
    public UISprite DevelopCrewIcon_a_UISprite;
    public UILabel DevCrewLevel_a_UILabel;
    public Transform TrainView_Transform;
    public Transform window_Transform;
    public UIButton BlackBG_UIButton;
    public UIButton Sure_UIButton;
    public UIButton Cancel_UIButton;
    public PageScrollView DevelopStrengthGrid_PageScrollView;
    public UIButton StrengthTipBtn_UIButton;
    public UISprite BgLabel_1_UISprite;
    public UIGrid StrengthenPageGrid_UIGrid;
    public Transform PartnerStrengthenView;
    public Transform PartnerDevelopView;
    public UISprite StrengthIconBG_a;
    public UISprite StrengthIconBG_b;
    public UISprite DevelopCrewIconBg_a;
    public UISprite DevelopCrewIconBg_b;
    public UILabel StrengthExpendTitle_UILabel;
    public UILabel ExpendTitle_UILabel;


    protected override void InitElementBinding ()
    {
	    var root = this.gameObject;
        //StrengLevelLabel_UILabel = root.FindScript<UILabel>("DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthTitle/CurLevel/StrengLevelLabel");      
        PartnerStrengthenView = root.FindTrans("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView ");
        PartnerDevelopView = root.FindTrans("Phasegroup/DevelopStrengthGrid/PartnerDevelopView");
        BeforeStrength_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthInfo/StrengthLevelTitle/BeforeStrength");
        AfterStrength_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthInfo/StrengthLevelTitle/AfterStrength");
        StrengthInfoGrid_UIGrid = root.FindScript<UIGrid>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthInfo/StrengthInfoGrid");
        CheckBtn_UIButton = root.FindScript<UIButton>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthInfo/CheckBtn");
        StrengthEffectLabel_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthInfo/StrengthEffectLabel");
        StrengthButton_UIButton = root.FindScript<UIButton>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthExpend/StrengthButton");
        StrengthExpendTitle_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthExpend/StrengthExpendTitle");
        ExpendTitle_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopExpend/ExpendTitle");
        StrengthMasAnchor_Transform = root.FindTrans("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthExpend/StrengthMasAnchor");
        BestStrengthLab_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthExpend/BestStrengthLab");
        ProgressGrid_UIGrid = root.FindScript<UIGrid>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/DevelopProgress/ProgressGrid");
        ColorLab_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/CurLevel/ColorLab");
        LevelLab_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/CurLevel/LevelLab");
        Label_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/DevelopProgress/Label");
        BeforeLevel_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopInfo/LevelTitle/BeforeLevel");
        AfterLevel_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopInfo/LevelTitle/AfterLevel");
        InfoGrid_UIGrid = root.FindScript<UIGrid>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopInfo/InfoGrid");
        EffectLabel_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopInfo/DevelopEffectBtn/EffectLabel");
        TipButton_UIButton = root.FindScript<UIButton>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopInfo/TipButton");
        ExpendGrid_UIGrid = root.FindScript<UIGrid>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopExpend/ExpendGrid");
        DevelopButton_UIButton = root.FindScript<UIButton>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopExpend/DevelopButton");
        BestDevelopLab_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopExpend/BestDevelopLab");
        DevelopEffectBtn_UIButton = root.FindScript<UIButton>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/DevelopInfo/DevelopEffectBtn");
        StrengthCrewIcon_b_UISprite = root.FindScript<UISprite>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthTitle/StrengthCrewIcon_b");
        strengthCrewIcon_a_UISprite = root.FindScript<UISprite>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthTitle/strengthCrewIcon_a");
        StrengthIconBG_a = root.FindScript<UISprite>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthTitle/strengthCrewIcon_a/StrenthIconBg_a");
        StrengthIconBG_b = root.FindScript<UISprite>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthTitle/StrengthCrewIcon_b/StrenthIconBg_b");
        StrengLevelLab_b_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthTitle/StrengthCrewIcon_b/StrengLevelLab_b");
        StrengLevelLabel_a_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthTitle/strengthCrewIcon_a/StrengLevelLabel_a");
        DevelopCrewIcon_b_UISprite = root.FindScript<UISprite>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/DevelopCrewIcon_b");
        DevelopCrewIconBg_b = root.FindScript<UISprite>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/DevelopCrewIcon_b/DevelopCrewIconBg_b");
        DevelopCrewIcon_a_UISprite = root.FindScript<UISprite>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/DevelopCrewIcon_a");
        DevelopCrewIconBg_a = root.FindScript<UISprite>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/DevelopCrewIcon_a/DevelopCrewIconBg_a");
        DevCrewLevel_b_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/DevelopCrewIcon_b/DevCrewLevel_b");
        DevCrewLevel_a_UILabel = root.FindScript<UILabel>("Phasegroup/DevelopStrengthGrid/PartnerDevelopView/PartnerDevelopGroup/PartnerTitle/DevelopCrewIcon_a/DevCrewLevel_a");
        TrainView_Transform = root.FindTrans("Phasegroup/DevelopStrengthGrid/TrainingView");
        window_Transform = root.FindTrans("window");
        BlackBG_UIButton = root.FindScript<UIButton>("window/BlackBG");
        Sure_UIButton = root.FindScript<UIButton>("window/btnWindowSave");
        Cancel_UIButton = root.FindScript<UIButton>("window/btnCancel");
        StrengthenPageGrid_UIGrid = root.FindScript<UIGrid>("StrengthenPageGrid");
        DevelopStrengthGrid_PageScrollView = root.FindScript<PageScrollView>("Phasegroup/DevelopStrengthGrid");
        StrengthTipBtn_UIButton = root.FindScript<UIButton>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /PartnerStrengGroup/StrengthInfo/StrengthTipBtn");
        BgLabel_1_UISprite = root.FindScript<UISprite>("Phasegroup/DevelopStrengthGrid/PartnerStrengthenView /BgLabel_1");

    }
    #endregion
}