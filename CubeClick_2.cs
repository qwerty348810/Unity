using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeClick_2 : MonoBehaviour
{
    public GameObject MySphere;
    public float score_2;
    bool click = true;
    float timerRemaining = 5;
    bool count = false;


    void Start()
    {

    }


    void Update()
    {
        if (count == true)
        {
            timerRemaining -= Time.deltaTime;
        }
    }
    private void OnMouseDown()
    {
        count = true;
        if (click == true)
        {
            Debug.Log("Spher Invis");
            MySphere.SetActive(false);
            click = false;
        }
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
            count = false;
            timerRemaining = 5;
            Debug.Log("Spher Visibl");
            MySphere.SetActive(true);
            click = true;
            score_2++;
        }
    }
}