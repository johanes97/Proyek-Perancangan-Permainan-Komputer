using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {
	public Transform bar;
	public float health;
	private static HealthBar healthBarInstance;
	
	// Use this for initialization
	void Start () {
		healthBarInstance = this;
		bar = transform.Find("bar");
		health = getHealth();	
		bar.localScale = new Vector3(health,0.99f);
	}
		
	public void setSize(float sizeNormalized){
		bar.localScale = new Vector3(sizeNormalized,0.99f);
	}
	
	public static HealthBar getInstance(){
		return healthBarInstance;
	}

	public float getHealth(){
		return PlayerPrefs.GetFloat("health",health);;
	}

	public void setHealth(){
		health += 0.04f;
		PlayerPrefs.SetFloat("health",health);
	} 
}
