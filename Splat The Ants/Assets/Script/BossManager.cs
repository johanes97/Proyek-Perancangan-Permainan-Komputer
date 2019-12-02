using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour {
	public int bossLives;
	public static BossManager bmInstance;

	void Awake(){
		bmInstance=this;
		bossLives = 15;
	}

	public static BossManager getInstance(){
		return bmInstance;
	}

	public void setBossLive(){
		bossLives--;
	}
	public int getBossLive(){
		return bossLives;
	}
}
