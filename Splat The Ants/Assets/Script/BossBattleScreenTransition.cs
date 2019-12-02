using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBattleScreenTransition : MonoBehaviour {

	public float waitingTime;
	public float timeElapsed;
	// Use this for initialization
	void Start () {
		waitingTime = 3f;
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;
		if(timeElapsed>waitingTime){
			ScreenChanger.getInstance().loadBossBattleArena();
		}
	}

}
