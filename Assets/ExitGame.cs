﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
	public void QuitGame() {
		Debug.Log("Quitting game..");
		Application.Quit();
	}	
}
