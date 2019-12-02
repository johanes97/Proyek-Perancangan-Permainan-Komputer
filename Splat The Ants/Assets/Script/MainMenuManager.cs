using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour {

	public Text highscoreText;
	public static MainMenuManager mainMenuInstance;

	void Awake(){
		//PlayerPrefs.SetInt("HighScore",0);
		mainMenuInstance=this;
	}
	void Start(){
    	highscoreText.text = "High Score: "+ getHighScoreNumber();  	
	}

	void Update(){
		highscoreText.text = "High Score: "+ getHighScoreNumber();
	}

	public static MainMenuManager getInstance(){
		return mainMenuInstance;
	}
	public void setHighScoreNumber(){
		HighScore.getInstance().setHighScoreNumber();
	}
	public int getHighScoreNumber(){
		return HighScore.getInstance().getHighScoreNumber();
	}
}
