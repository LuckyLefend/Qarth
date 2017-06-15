﻿//  Desc:        Framework For Game Develop with Unity3d
//  Copyright:   Copyright (C) 2017 SnowCold. All rights reserved.
//  WebSite:     https://github.com/SnowCold/Qarth
//  Blog:        http://blog.csdn.net/snowcoldgame
//  Author:      SnowCold
//  E-mail:      snowcold.ouyang@gmail.com
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Qarth.LoopScrollRect))]
[DisallowMultipleComponent]
public class InitOnStart : MonoBehaviour {
	void Start () {
        GetComponent<Qarth.LoopScrollRect>().RefillCells();
	}
}