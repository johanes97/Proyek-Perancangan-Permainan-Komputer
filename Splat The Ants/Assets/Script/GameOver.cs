using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public Text endScore;
	// Use this for initialization
	void Start () {
		endScore.text = "Score: "+PlayerPrefs.GetInt("Score",Score.getInstance().getScoreNumber());
		if(Score.getInstance().getScoreNumber()>MainMenuManager.getInstance().getHighScoreNumber()){
			MainMenuManager.getInstance().setHighScoreNumber();
		}
		PlayerPrefs.SetInt("LivesNum",3);
		PlayerPrefs.SetInt("Level",1);
		PlayerPrefs.SetInt("CounterAnt",10);
		PlayerPrefs.SetFloat("health",-0.1386449f);
		PlayerPrefs.SetInt("Score",0);
	}
}
