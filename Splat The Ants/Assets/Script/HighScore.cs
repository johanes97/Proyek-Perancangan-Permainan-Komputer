using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
public class HighScore : MonoBehaviour {

	public static int highscoreNumber = 0;
	public static HighScore highscoreInstance;
	// Use this for initialization
	void Start () {
		highscoreInstance = this;		
		highscoreNumber = 0;
		LogLevelEvent();
	}
	public static HighScore getInstance(){
		return highscoreInstance;
	}
	public void setHighScoreNumber(){
		highscoreNumber = Score.getInstance().getScoreNumber();
		PlayerPrefs.SetInt("HighScore",highscoreNumber);
	}
	public int getHighScoreNumber(){
		return PlayerPrefs.GetInt("HighScore",highscoreNumber);
	}
	public void LogLevelEvent() {
    	FB.LogAppEvent(
        	getHighScoreNumber()+""
    	);
    	Debug.Log("masuk log even highscore");
	}
}
