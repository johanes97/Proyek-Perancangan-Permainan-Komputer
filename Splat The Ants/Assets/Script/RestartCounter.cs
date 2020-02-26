using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
public class RestartCounter : MonoBehaviour {

	public int counterRestart;
	public static RestartCounter restartInstance;
	// Use this for initialization
	void Start () {
		restartInstance = this;
		counterRestart = getRestartCounter();
		PlayerPrefs.SetInt("CounterRestart",counterRestart);
		LogRestartCounterEvent();
		Debug.Log("ini udh restart brp kali: "+getRestartCounter()+"");
	}
	public static RestartCounter getInstance(){
		return restartInstance;
	}
	public void setRestartCounter(){
		counterRestart++;
		PlayerPrefs.SetInt("CounterRestart",counterRestart);
	}
	public int getRestartCounter(){
		return PlayerPrefs.GetInt("CounterRestart",counterRestart);
	}

	public void LogRestartCounterEvent() {
    	FB.LogAppEvent("Total Restart",getRestartCounter());
    	Debug.Log("masuk log even restart counter");
	}
}
