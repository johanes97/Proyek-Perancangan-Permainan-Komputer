using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowAnt : MonoBehaviour {

	private Rigidbody2D rb;
	private Vector2 screenBounds;
	private int live;
	public static YellowAnt yellowAntInstance;
	// Use this for initialization
	void Start () {
		live = 2;
		yellowAntInstance = this;
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(0,Random.Range(1,3)*-1);
		Physics2D.IgnoreLayerCollision(9,8);
		Physics2D.IgnoreLayerCollision(9,9);
		Physics2D.IgnoreLayerCollision(9,10);
		Physics2D.IgnoreLayerCollision(9,11);
		Physics2D.IgnoreLayerCollision(9,12);
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
		else if(live == 0){
			ScreenManager.getInstance().setScoreNumber();
			ScreenManager.getInstance().setCounterAnt();
			Destroy(this.gameObject);
		}
	}
	private void OnMouseDown(){
		if(!Pause.getInstance().getConditionPause()){
			live--;
		}
	}

	public static YellowAnt getInstance(){
		return yellowAntInstance;
	}
}
