using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteCubeClick : MonoBehaviour {

    
    public GameObject imageActive;
    void Start()
    {
               
    }
    private void OnMouseDown()
    {
        imageActive.SetActive(true);
        Debug.Log("Yes!!!!!");
    }
}
