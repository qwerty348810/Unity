using System.Collections;
using UnityEngine;

public class CubeClick : MonoBehaviour {
    float timerRemaining = 5;
    bool count = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (count == true) {
            timerRemaining -= Time.deltaTime;
        }
        
    }
    private void OnMouseDown(){
        count = true;
        Debug.Log ("Test 2!!!!!!!");
	}
    void OnGUI()
    {
        if (timerRemaining > 0)
        {
            GUI.Label(new Rect(100, 100, 200, 100), "Time Ramaining:" + timerRemaining);
        }
        else
        {
            GUI.Label(new Rect(100, 100, 100, 100), "Time s UP");
        }
    }

}
