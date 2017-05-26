using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public GameObject MySphere;
    public bool click = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        if(click == true) {
            Debug.Log("Spher Invis");
            MySphere.SetActive(false);
            click = false;
        }
        else
        {
            Debug.Log("Spher Visibl");
            MySphere.SetActive(true);
            click = true;
        }
    }
}
