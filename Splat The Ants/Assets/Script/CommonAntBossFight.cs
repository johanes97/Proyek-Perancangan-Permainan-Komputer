using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonAntBossFight : MonoBehaviour {

	private Rigidbody2D rb;
	private Vector2 screenBounds;
	public static CommonAntBossFight commonAntBossFightInstance;
	// Use this for initialization
	void Start () {
		commonAntBossFightInstance = this;
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(0,Random.Range(4,6)*-1);
		Physics2D.IgnoreCollision(this.gameObject.GetComponent<CircleCollider2D>(), BossAnt.getInstance().GetComponent<CircleCollider2D>());
		Physics2D.IgnoreLayerCollision(13,13);
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.y < -4.0){
			HealthBar.getInstance().setHealth();
			HealthBar.getInstance().setSize(HealthBar.getInstance().getHealth());
			ScreenManager.getInstance().setLivesNumber();
			Debug.Log(ScreenManager.getInstance().getCounterAnt());
			Destroy(this.gameObject);		
		}
		else if(ScreenManager.getInstance().getLivesNumber()==0){
			ScreenChanger.getInstance().loadGameOver();
			Destroy(this.gameObject);	
		}
	}
	private void OnMouseDown(){
		AntKillCounter.getInstance().setKillCounter();
		ScreenManager.getInstance().setScoreNumber();
		Destroy(this.gameObject);
	}

	public static CommonAntBossFight getInstance(){
		return commonAntBossFightInstance;
	}
}
