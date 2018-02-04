﻿using UnityEngine;
using System.Collections.Generic;

public class WeaponConfig
{
	public List<WeaponBindConfig> list = new List<WeaponBindConfig>();
}

public class WeaponBindConfig
{
	public string key = "";

	public Vector3 localPosition = Vector3.zero;
	public Vector3 localEulerAngles = Vector3.zero;
}