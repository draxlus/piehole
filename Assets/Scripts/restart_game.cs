﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart_game : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			Application.LoadLevel("pie_hell_prototype");
		}
		
		if (Input.GetButtonDown("Cancel")) {
			Application.Quit();
		}
	}
}
