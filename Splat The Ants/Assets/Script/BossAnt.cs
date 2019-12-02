using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnt : MonoBehaviour {

	private Rigidbody2D rb;
	private Vector2 screenBounds;
	private bool flag;
	public static BossAnt bossAntInstance;
	// Use this for initialization
	void Start () {
		flag = false;
		bossAntInstance = this;
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(0,Random.Range(2,4)*-1);
		Physics2D.IgnoreCollision(this.gameObject.GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.y < -3.8){
			ScreenChanger.getInstance().loadGameOver();
			Destroy(this.gameObject);		
		}
		else if(BossScreenManager.getInstance().getLivesNumber()==0){
			ScreenChanger.getInstance().loadGameOver();
			Destroy(this.gameObject);	
		}
		else if(BossManager.getInstance().getBossLive()==0){
			BossScreenManager.getInstance().setBossScoreNumber();
			BossScreenManager.getInstance().setLevel();
			BossScreenManager.getInstance().addCounterAnt();
			ScreenChanger.getInstance().loadGame();
			Destroy(this.gameObject);	
		}
		else if(transform.position.y < -1.5){
			if(!flag){
				flag = true;
				rb.velocity = new Vector2(0,Random.Range(1,2)*2);
			}
		}
		
	}

	private void OnMouseDown(){
		BossManager.getInstance().setBossLive();
	}

	public static BossAnt getInstance(){
		return bossAntInstance;
	}
}
