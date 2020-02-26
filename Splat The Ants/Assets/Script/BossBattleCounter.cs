using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
public class BossBattleCounter : MonoBehaviour {

	public int bossBattleCounter;
	public static BossBattleCounter bossCounterInstance;
	// Use this for initialization
	void Start () {
		bossCounterInstance = this;
		bossBattleCounter = getCounterBoss();
		setCounterBoss();
		PlayerPrefs.SetInt("BossBattleCounter",bossBattleCounter);
		LogBossCounterEvent();
		Debug.Log("ini boss battle counter: "+getCounterBoss()+"");
	}
	public static BossBattleCounter getInstance(){
		return bossCounterInstance;
	}
	public void setCounterBoss(){
		bossBattleCounter++;
		PlayerPrefs.SetInt("BossBattleCounter",bossBattleCounter);
	}
	public int getCounterBoss(){
		return PlayerPrefs.GetInt("BossBattleCounter",bossBattleCounter);
	}

	public void LogBossCounterEvent() {
    	FB.LogAppEvent("Total Boss Encounter",getCounterBoss());
    	Debug.Log("masuk log even boss counter");
	}
}
