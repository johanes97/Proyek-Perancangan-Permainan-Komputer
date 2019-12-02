using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowAntManager : MonoBehaviour {

	public GameObject antPrefab;
	private float respawnTime = 3.5f;
	private Vector2 screenBounds;
	private GameObject ant;

	// Use this for initialization
	void Start () {
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height));
		StartCoroutine(antsWave());	
	}
	
	// Update is called once per frame
	private void spawnAnts () {
		ant = Instantiate(antPrefab) as GameObject;
		ant.transform.position = new Vector2(Random.Range(-screenBounds.x*0.8f,screenBounds.x*0.8f),screenBounds.y);
		Debug.Log(ScreenManager.getInstance().getCounterAnt()+"");
	}
	IEnumerator antsWave(){
		while(true){
			yield return new WaitForSeconds(respawnTime);
			spawnAnts();
		}
	}
}
