using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public static int scoreNumber = 0;
	public static Score scoreInstance;
	// Use this for initialization
	void Start () {
		scoreInstance = this;		
		scoreNumber = getScoreNumber();
	}
	public static Score getInstance(){
		return scoreInstance;
	}
	public void setScoreNumber(){
		scoreNumber++;
		PlayerPrefs.SetInt("Score",scoreNumber);
	}
	public void setBossScoreNumber(){
		scoreNumber+=10;
		PlayerPrefs.SetInt("Score",scoreNumber);
	}
	public int getScoreNumber(){
		return PlayerPrefs.GetInt("Score",scoreNumber);
	}
}
