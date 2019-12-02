using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

	public int level;
	public static Level levelInstance;
	// Use this for initialization
	void Start () {
		levelInstance = this;
		level = getLevel();
		PlayerPrefs.SetInt("Level",level);
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
}
