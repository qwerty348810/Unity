using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour {
    float timerRemaining = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timerRemaining -= Time.deltaTime;	
	}

    void OnGUI() {
        if (timerRemaining>0)
        {
            GUI.Label(new Rect(100, 100, 200, 100), "Time Ramaining:" + timerRemaining);
        }
        else {
            GUI.Label(new Rect(100, 100, 100, 100), "Time s UP");
        }
    }
}
