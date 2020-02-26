using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
public class AntKillCounter : MonoBehaviour {

	public int killCounter;
	public static AntKillCounter antKillInstance;
	// Use this for initialization
	void Start () {
		antKillInstance = this;
		killCounter = getKillCounter();
		PlayerPrefs.SetInt("AntKillCounter",killCounter);
		LogAntKillEvent();
		Debug.Log("ini udh bunuh brp semut: "+getKillCounter()+"");
	}
	public static AntKillCounter getInstance(){
		return antKillInstance;
	}
	public void setKillCounter(){
		killCounter++;
		PlayerPrefs.SetInt("AntKillCounter",killCounter);
	}
	public int getKillCounter(){
		return PlayerPrefs.GetInt("AntKillCounter",killCounter);
	}

	public void LogAntKillEvent() {
    	FB.LogAppEvent("Total Ant Kill",getKillCounter());
    	Debug.Log("masuk log even itung bunuh semut");
	}
}
