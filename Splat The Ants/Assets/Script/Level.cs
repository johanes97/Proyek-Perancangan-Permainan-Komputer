using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
public class Level : MonoBehaviour {

	public int level;
	public int highestLevel;
	public static Level levelInstance;
	// Use this for initialization
	void Start () {
		levelInstance = this;
		level = getLevel();
		PlayerPrefs.SetInt("HighestLevel",highestLevel);
		PlayerPrefs.SetInt("Level",level);
		LogLevelEvent();
	}
	public static Level getInstance(){
		return levelInstance;
	}
	public void setLevel(){
		level++;
		PlayerPrefs.SetInt("Level",level);
	}
	public int getLevel(){
		return PlayerPrefs.GetInt("Level",level);
	}

	public int getHighestLevel(){
		if(getLevel()>PlayerPrefs.GetInt("HighestLevel",highestLevel)){
			highestLevel = getLevel();
			PlayerPrefs.SetInt("HighestLevel",highestLevel);
		}
		return PlayerPrefs.GetInt("HighestLevel",highestLevel);
	}
	public void LogLevelEvent() {
    	FB.LogAppEvent(
        	getHighestLevel()+""
    	);
    	Debug.Log("masuk log even level");
	}
}
