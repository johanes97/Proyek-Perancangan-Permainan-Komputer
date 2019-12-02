using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour {

	public Text scoreText;
	public Text antCounterText;
	public Text pausedText;
	public static ScreenManager instance;

	void Awake(){
		instance=this;
	}
	void Start(){
    	scoreText.text = "Score: "+ getScoreNumber();
    	antCounterText.text = "X: "+ getScoreNumber();
    	pausedText.text = "";
	}

	void Update(){
		scoreText.text = "Score: "+ getScoreNumber();
    	antCounterText.text = "X: "+ getCounterAnt();
    	if(Pause.getInstance().getConditionPause()){
    		pausedText.text = "PAUSED";
    	}
    	else if(!Pause.getInstance().getConditionPause()){
    		pausedText.text = "";
    	}
	}

	public static ScreenManager getInstance(){
		return instance;
	}
	public void setScoreNumber(){
		Score.getInstance().setScoreNumber();
	}
	public int getScoreNumber(){
		return Score.getInstance().getScoreNumber();
	}
	public void setLivesNumber(){
		Lives.getInstance().setLivesNumber();
	}
	public int getLivesNumber(){
		return Lives.getInstance().getLivesNumber();
	}
	public void setCounterAnt(){
		AntCounter.getInstance().setCounterAnt();
	}
	public int getCounterAnt(){
		return AntCounter.getInstance().getCounterAnt();
	}
	public int getLevel(){
		return Level.getInstance().getLevel();
	}
}
