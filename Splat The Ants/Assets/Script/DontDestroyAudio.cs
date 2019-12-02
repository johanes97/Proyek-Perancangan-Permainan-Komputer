using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour {

	// Use this for initialization
	public static DontDestroyAudio musicInstance = null; 
	void Awake () {		
		if (musicInstance != null)
        {
            Destroy(gameObject);
        }
        else { 
        	musicInstance = this;
            DontDestroyOnLoad(gameObject);
        }	
	}
}
