﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleAnt : MonoBehaviour {

	private Rigidbody2D rb;
	private Vector2 screenBounds;
	public static InvisibleAnt invisibleAntInstance;
	// Use this for initialization
	void Start () {
		invisibleAntInstance = this;
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(0,Random.Range(3,6)*-1);
		Physics2D.IgnoreLayerCollision(11,8);
		Physics2D.IgnoreLayerCollision(11,9);
		Physics2D.IgnoreLayerCollision(11,10);
		Physics2D.IgnoreLayerCollision(11,11);
		Physics2D.IgnoreLayerCollision(11,12);
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.y < -3.8){
			HealthBar.getInstance().setHealth();
			HealthBar.getInstance().setSize(HealthBar.getInstance().getHealth());
			ScreenManager.getInstance().setLivesNumber();
			ScreenManager.getInstance().setCounterAnt();
			Debug.Log(ScreenManager.getInstance().getCounterAnt());
			Destroy(this.gameObject);		
		}
		else if(ScreenManager.getInstance().getLivesNumber()==0){
			ScreenChanger.getInstance().loadGameOver();
			Destroy(this.gameObject);	
		}
		else if(ScreenManager.getInstance().getCounterAnt()==0){
			ScreenChanger.getInstance().loadBossBattleTransition();
			Destroy(this.gameObject);	
		}
	}
	private void OnMouseDown(){
		if(!Pause.getInstance().getConditionPause()){
			AntKillCounter.getInstance().setKillCounter();
			ScreenManager.getInstance().setScoreNumber();
			ScreenManager.getInstance().setCounterAnt();
			Destroy(this.gameObject);
		}
	}

	public static InvisibleAnt getInstance(){
		return invisibleAntInstance;
	}
}
