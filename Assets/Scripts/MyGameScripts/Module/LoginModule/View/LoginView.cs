﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for LoginView.
/// </summary>
public partial class LoginView : BaseView
{
    public const string NAME ="LoginView";
    public UILabel VersionLabel_UILabel;
    public Transform StartPanel_Transform;
    public Transform LoadingPanel_Transform;
    public UITexture LoadingTexture_UITexture;
    public UIButton StartGameButton_UIButton;
    public UIButton LastLoginInfo_UIButton;
    public UILabel LastLoginInfo_label_UILabel;
    public UISprite LastLoginInfo_state_UISprite;
    public UIButton MovieButton_UIButton;
    public UISlider loadingSlider_UISlider;
    public UILabel LoadingLabel_UILabel;
    public UIButton AccountButton_UIButton;
    public UIButton AgreementButton_UIButton;
    public UIButton NoticeButton_UIButton;
    public GameObject ButtonGroup;
    public UILabel AccountTipLabel_UILabel;
    public UIWidget AccountTipGroupWidget;
    public Transform loadingSliderThumb;
    public UILabel LastLoginRoleInfo_label_UILabel;
    public GameObject LastLoginRoleInfo;
    public UIButton LastLoginRoleInfo_UIButton;
    public UITexture LogoTexture_UITexture;
    public UIButton ShowBtn_UIButton;
    public UIButton RestoreBtn_UIButton;
    public UIButton ChangeUrlBtn_UIButton;
    public UIButton VersionLabel_UIButton;
    public UILabel LoadingTips_UILabel;
    public UIButton SPLoginButton_UIButton;
    public UIButton QRCodeScanBtn_UIButton;
    public UILabel BanhaoLabel_UILabel;
    public GameObject ShowDes_Go;

    protected override void InitElementBinding ()
    {
        var root = this.gameObject.transform;
        VersionLabel_UILabel = root.Find("TopRightAnchor/VersionLabel").GetComponent<UILabel>();
        StartPanel_Transform = root.Find("Content/StartPanel");
        LoadingPanel_Transform = root.Find("Content/LoadingPanel");
        LoadingTexture_UITexture = root.Find("Content/LoadingTexture").GetComponent<UITexture>();
        StartGameButton_UIButton = root.Find("Content/StartPanel/StartGameButton").GetComponent<UIButton>();
        LastLoginInfo_UIButton = root.Find("Content/StartPanel/LastLoginInfo").GetComponent<UIButton>();
        LastLoginInfo_label_UILabel = root.Find("Content/StartPanel/LastLoginInfo/LastLoginInfo_label").GetComponent<UILabel>();
        LastLoginInfo_state_UISprite = root.Find("Content/StartPanel/LastLoginInfo/LastLoginInfo_state").GetComponent<UISprite>();
        MovieButton_UIButton = root.Find("Content/ButtonGroup/MovieButton").GetComponent<UIButton>();
        loadingSlider_UISlider = root.Find("Content/LoadingPanel/loadingSlider").GetComponent<UISlider>();
        LoadingLabel_UILabel = root.Find("Content/LoadingPanel/loadingSlider/LoadingLabel").GetComponent<UILabel>();
        AccountButton_UIButton = root.Find("Content/ButtonGroup/AccountButton").GetComponent<UIButton>();
        AgreementButton_UIButton = root.Find("Content/ButtonGroup/AgreementButton").GetComponent<UIButton>();
        NoticeButton_UIButton = root.Find("Content/ButtonGroup/NoticeButton").GetComponent<UIButton>();
        ButtonGroup = root.Find("Content/ButtonGroup").gameObject;
        AccountTipLabel_UILabel = root.Find("Content/AccountTipGroup/AccountTipLabel").GetComponent<UILabel>();
        AccountTipGroupWidget = root.Find("Content/AccountTipGroup").GetComponent<UIWidget>();
        loadingSliderThumb = root.Find("Content/LoadingPanel/loadingSlider/loadingSliderThumb");
        LastLoginRoleInfo_label_UILabel = root.Find("Content/StartPanel/LastLoginRoleInfo/LastLoginRoleInfo_label").GetComponent<UILabel>();
        LastLoginRoleInfo = root.Find("Content/StartPanel/LastLoginRoleInfo").gameObject;
        LastLoginRoleInfo_UIButton = root.Find("Content/StartPanel/LastLoginRoleInfo").GetComponent<UIButton>();
        LogoTexture_UITexture = root.Find("Content/LogoTexture").GetComponent<UITexture>();
        ShowBtn_UIButton = root.Find("TopRightAnchor/ShowBtn").GetComponent<UIButton>();
        RestoreBtn_UIButton = root.Find("TopRightAnchor/RestoreBtn").GetComponent<UIButton>();
        ChangeUrlBtn_UIButton = root.Find("TopRightAnchor/ChangeUrlBtn").GetComponent<UIButton>();
        VersionLabel_UIButton = root.Find("TopRightAnchor/VersionLabel").GetComponent<UIButton>();
        LoadingTips_UILabel = root.Find("Content/LoadingPanel/tipBg/tipLbl").GetComponent<UILabel>();
        SPLoginButton_UIButton = root.Find("Content/ButtonGroup/SPLoginButton").GetComponent<UIButton>();
        QRCodeScanBtn_UIButton = root.Find("Content/ButtonGroup/QRCodeScanBtn").GetComponent<UIButton>();
        BanhaoLabel_UILabel = root.Find("TopRightAnchor/BanhaoLabel").GetComponent<UILabel>();
        ShowDes_Go = root.Find("Content/VersionDes").gameObject;
    }
}