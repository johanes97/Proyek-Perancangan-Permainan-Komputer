using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScreenManager : MonoBehaviour {
	
	public Text scoreText;
	public static BossScreenManager bossScreenManagerInstance;

	void Awake(){
		bossScreenManagerInstance=this;
	}
	void Start(){
    	scoreText.text = "Score: "+Score.getInstance().getScoreNumber();
	}

	void Update(){
		scoreText.text = "Score: "+Score.getInstance().getScoreNumber();
	}

	public static BossScreenManager getInstance(){
		return bossScreenManagerInstance;
	}
	public void setScoreNumber(){
		Score.getInstance().setScoreNumber();
	}
	public void setBossScoreNumber(){
		Score.getInstance().setBossScoreNumber();
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
	public void addCounterAnt(){
		AntCounter.getInstance().addCounterAnt();
	}
	public void setLevel(){
		Level.getInstance().setLevel();
	}
}
