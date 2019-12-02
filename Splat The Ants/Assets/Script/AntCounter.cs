using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntCounter : MonoBehaviour {

	public int counterAnt;
	public static AntCounter antCounterInstance;
	// Use this for initialization
	void Start () {
		antCounterInstance = this;
		if(ScreenManager.getInstance().getLevel()==1){
			counterAnt = 10;
		}
		else{
			counterAnt = getCounterAnt();	
		}
	}
	public static AntCounter getInstance(){
		return antCounterInstance;
	}
	public void setCounterAnt(){
		counterAnt--;
		PlayerPrefs.SetInt("CounterAnt",counterAnt);
	}
	public void addCounterAnt(){
		counterAnt+=10*Level.getInstance().getLevel();
		PlayerPrefs.SetInt("CounterAnt",counterAnt);
	}
	public int getCounterAnt(){
		return PlayerPrefs.GetInt("CounterAnt",counterAnt);;
	}
}
