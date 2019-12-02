using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour {

	public int livesNumber;
	public static Lives livesInstance;
	// Use this for initialization
	void Start () {
		livesInstance = this;
		if(ScreenManager.getInstance().getLevel()==1){
			livesNumber = 3;
		}
		else{
			livesNumber = getLivesNumber();	
		}
	}
	public static Lives getInstance(){
		return livesInstance;
	}
	public void setLivesNumber(){
		livesNumber--;
		PlayerPrefs.SetInt("LivesNum",livesNumber);
	}
	public int getLivesNumber(){
		return PlayerPrefs.GetInt("LivesNum",livesNumber);
	}
}
