﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public static SceneController instance;

	void Awake(){
		if (instance == null){
			instance = this;
			DontDestroyOnLoad(gameObject);
		}else{
			Destroy(gameObject);
		}
	}

	public void MainMenu(){
		SceneManager.LoadScene(0);
	}
	public void ToGame(){
		SceneManager.LoadScene(1);
	}
}
