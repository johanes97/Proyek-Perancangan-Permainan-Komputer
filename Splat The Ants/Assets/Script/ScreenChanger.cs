using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenChanger : MonoBehaviour {

	public static ScreenChanger scInstance;

	void Awake(){
		scInstance=this;
	}

	public static ScreenChanger getInstance(){
		return scInstance;
	}

	public void loadTutorial(){
    	SceneManager.LoadScene("Tutorial");
	}

	public void loadGame(){
    	SceneManager.LoadScene("MainGame");
	}

	public void loadMenu(){
    	SceneManager.LoadScene("MainMenu");
	}

	public void loadCredit(){
		SceneManager.LoadScene("Credits");
	}

	public void loadGameOver(){
		SceneManager.LoadScene("GameOver");
	}

	public void loadBossBattleTransition(){
		SceneManager.LoadScene("BossBattleTransition");
	}

	public void loadBossBattleArena(){
		SceneManager.LoadScene("BossBattleArena");
	}
	public void quit(){
		PlayerPrefs.SetInt("LivesNum",3);
		PlayerPrefs.SetInt("Level",1);
		PlayerPrefs.SetInt("CounterAnt",10);
		PlayerPrefs.SetFloat("health",-0.1386449f);
		PlayerPrefs.SetInt("Score",0);
    	Application.Quit();
	}
}
