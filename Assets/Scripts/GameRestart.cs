﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour {
	
	void Update () {
		if (transform.position.y <= -10) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
