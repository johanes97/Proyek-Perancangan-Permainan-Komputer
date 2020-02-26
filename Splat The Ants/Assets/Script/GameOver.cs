using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;
public class GameOver : MonoBehaviour { 
	public int gameOverCounter;
	public Text endScore;
	public static GameOver gameOverInstance;
	// Use this for initialization
	void Start () {
		gameOverInstance = this;
		endScore.text = "Score: "+PlayerPrefs.GetInt("Score",Score.getInstance().getScoreNumber());
		if(Score.getInstance().getScoreNumber()>MainMenuManager.getInstance().getHighScoreNumber()){
			MainMenuManager.getInstance().setHighScoreNumber();
		}
		gameOverCounter = getCounterGameOver();
		setCounterGameOver();
		PlayerPrefs.SetInt("LivesNum",3);
		PlayerPrefs.SetInt("Level",1);
		PlayerPrefs.SetInt("CounterAnt",10);
		PlayerPrefs.SetFloat("health",-0.1386449f);
		PlayerPrefs.SetInt("Score",0);
		LogLevelEvent();
		Debug.Log("ini gameover: "+getCounterGameOver()+"");
	}

	public static GameOver getInstance(){
		return gameOverInstance;
	}

	public void setCounterGameOver(){
		gameOverCounter++;
		PlayerPrefs.SetInt("GameOverCounter",gameOverCounter);
	}

	public int getCounterGameOver(){
		return PlayerPrefs.GetInt("GameOverCounter",gameOverCounter);
	}

	public void LogLevelEvent() {
    	FB.LogAppEvent(
        	getCounterGameOver()+""
    	);
    	Debug.Log("masuk log even gameover");
	}
}
