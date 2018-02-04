﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for GameRoot.
/// </summary>
public partial class GameRoot : BaseView
{
	public const string NAME ="GameRoot";
	public GameObject AudioManager;
	public GameObject BattleLayer;
	public GameObject SceneLayer;
	public GameObject WorldActors;
	public GameObject BattleActors;
	public GameObject StoryActors;
	public GameObject EffectsAnchor;
	public Camera SceneCamera;
	public Transform SceneCameraTrans;
	public Camera SceneHUDCamera;
	public UICamera UICamera;
	public UITexture BattleBgTexture;
	public GameObject UIModuleRoot;
	public UIPanel SceneHudTextPanel;
	public UIPanel PlotHudTextPanel;
	public UIPanel BattleHudTextPanel;
	public UIPanel SceneUIHUDPanel;
	public UIPanel PlotUIHUDPanel;
	public UIPanel BattleUIHUDPanel;
	public UIPanel FloatTipPanel;
	public UIPanel TopFloatTipPanel;
	public UIPanel LockScreenPanel;
	public Animator BattleCamera_Animator;
	public Camera BattleCamera_Camera;
	public Transform BattleCameraTrans;
	public Transform BattlePositionCntr_Transform;
    public Transform SceneRotationCntr_Transform;
	
	public Transform BattleDefaultRotationCntr_Transform;
	
    public Transform  ScenePositionCameraTrans;

    public Transform SceneDefaultCameraTrans;
    public GameObject AstarPath;

    protected override void InitElementBinding ()
	{
		var root = this.gameObject.transform;
		AudioManager = root.Find("AudioManager").gameObject;
		BattleLayer = root.Find("World/BattleLayer").gameObject;
		SceneLayer = root.Find("World/SceneLayer").gameObject;
		WorldActors = root.Find("Gameplay/WorldActors").gameObject;
		BattleActors = root.Find("Gameplay/BattleActors").gameObject;
		StoryActors = root.Find("Gameplay/StoryActors").gameObject;
		EffectsAnchor = root.Find("Gameplay/EffectsAnchor").gameObject;
		SceneCamera = root.Find("Cameras/ScenePositionCntr/SceneRotationCntr/SceneDefaultRotationCntr/SceneCamera").GetComponent<Camera>();


        ScenePositionCameraTrans = root.Find("Cameras/ScenePositionCntr");
        SceneRotationCntr_Transform = root.Find("Cameras/ScenePositionCntr/SceneRotationCntr");
        SceneDefaultCameraTrans = root.Find("Cameras/ScenePositionCntr/SceneRotationCntr/SceneDefaultRotationCntr");

		SceneCameraTrans = root.Find("Cameras/ScenePositionCntr/SceneRotationCntr/SceneDefaultRotationCntr/SceneCamera");

		SceneHUDCamera = root.Find("Cameras/ScenePositionCntr/SceneRotationCntr/SceneDefaultRotationCntr/SceneCamera/SceneHUD/SceneHUDCamera").GetComponent<Camera>();
		UICamera = root.Find("GUI/UICamera").GetComponent<UICamera>();
		BattleBgTexture = root.Find("Cameras/ScenePositionCntr/SceneRotationCntr/SceneDefaultRotationCntr/SceneCamera/SceneHUD/SceneHUDCamera/BattleBgTexture").GetComponent<UITexture>();
		UIModuleRoot = root.Find("GUI/UICamera/UIModuleRoot").gameObject;
		SceneHudTextPanel = root.Find("Cameras/ScenePositionCntr/SceneRotationCntr/SceneDefaultRotationCntr/SceneCamera/SceneHUD/SceneHUDCamera/SceneHudTextPanel").GetComponent<UIPanel>();
		PlotHudTextPanel = root.Find("Cameras/ScenePositionCntr/SceneRotationCntr/SceneDefaultRotationCntr/SceneCamera/SceneHUD/SceneHUDCamera/PlotHudTextPanel").GetComponent<UIPanel>();
		BattleHudTextPanel = root.Find("Cameras/ScenePositionCntr/SceneRotationCntr/SceneDefaultRotationCntr/SceneCamera/SceneHUD/SceneHUDCamera/BattleHudTextPanel").GetComponent<UIPanel>();
		SceneUIHUDPanel = root.Find("GUI/UICamera/FrontAnchor/SceneUIHUDPanel").GetComponent<UIPanel>();
		PlotUIHUDPanel = root.Find("GUI/UICamera/FrontAnchor/PlotUIHUDPanel").GetComponent<UIPanel>();
		BattleUIHUDPanel = root.Find("GUI/UICamera/FrontAnchor/BattleUIHUDPanel").GetComponent<UIPanel>();
		FloatTipPanel = root.Find("GUI/UICamera/FrontAnchor/FloatTipPanel").GetComponent<UIPanel>();
		TopFloatTipPanel = root.Find("GUI/UICamera/FrontAnchor/TopFloatTipPanel").GetComponent<UIPanel>();
		LockScreenPanel = root.Find("GUI/UICamera/FrontAnchor/LockScreenPanel").GetComponent<UIPanel>();
		BattleCamera_Animator = root.Find("Cameras/BattlePostionCntr/BattleDefaultRotationCntr/BattleCamera").GetComponent<Animator>();
		BattleCamera_Camera = root.Find("Cameras/BattlePostionCntr/BattleDefaultRotationCntr/BattleCamera").GetComponent<Camera>();
		BattleCameraTrans = root.Find("Cameras/BattlePostionCntr/BattleDefaultRotationCntr/BattleCamera");
		BattleDefaultRotationCntr_Transform =
			root.Find("Cameras/BattlePostionCntr/BattleDefaultRotationCntr");
		BattlePositionCntr_Transform = root.Find("Cameras/BattlePostionCntr");
        AstarPath = root.Find("World/AstarPath").gameObject;
	}
}