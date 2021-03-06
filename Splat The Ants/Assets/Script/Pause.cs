﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
public class Pause : MonoBehaviour {

	private bool isPause = false;
	public static Pause pauseInstance;

	void Start(){
		pauseInstance = this;
	}
	public void pauseGame(){
		if(isPause){
			Time.timeScale = 1;
			isPause = false;
			isPause = false;
			if (FB.IsInitialized) {
      			FB.ActivateApp();
    		} 
    		else {
      		//Handle FB.Init
      		FB.Init( () => {
        	FB.ActivateApp();
      		});
    		}
		}
		else{
			Time.timeScale = 0;
			isPause = true;
		}
	}

	public bool getConditionPause(){
		return isPause;
	}
	public static Pause getInstance(){
		return pauseInstance;
	}
}
