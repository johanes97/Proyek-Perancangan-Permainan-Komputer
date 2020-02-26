using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;
public class MainMenuManager : MonoBehaviour {

	public Text highscoreText;
	public static MainMenuManager mainMenuInstance;

	void Awake(){
		// PlayerPrefs.SetInt("HighestLevel",0);
		// PlayerPrefs.SetInt("HighScore",0);
		// PlayerPrefs.SetInt("CounterRestart",0);
		// PlayerPrefs.SetInt("GameOverCounter",0);
		// PlayerPrefs.SetInt("BossBattleCounter",0);
		// PlayerPrefs.SetInt("AntKillCounter",0);
		mainMenuInstance=this;
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
