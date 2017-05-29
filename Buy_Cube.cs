using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy_Cube : MonoBehaviour
{
    public Score score;
    private CubeClick cubclick_1;
    private CubeClick cubclick_2;
    private CubeClick cubclick_3;
    private CubeClick cubclick_4;
    private CubeClick cubclick_5;
    private CubeClick cubclick_6;
    public NotActive cube_2;
    public NotActive textAlert;
    public NotActive textAlert_2;
    public float prov;
    bool provCube = false;

    float timeRemaining = 3.0f;
    public float deletScore;


    void Update()
    {

        timeRemaining -= Time.deltaTime;
        if (timeRemaining < 0)
        {
            textAlert.active.SetActive(false);
            textAlert_2.active.SetActive(false);
        }   


       prov = score.GetScoreGlobal();
    }
    public void Button_Click()
    {

        if (prov >= 2)
        {
            if (provCube == true)
            {
                textAlert_2.active.SetActive(true);
                timeRemaining = 3.0f;
            }
            if (provCube == false)
            {
                cube_2.active.SetActive(true);
                deletScore -= 2;
                provCube = true;               
            }           
        }
        else
        {
            if(provCube == true)
            {
                textAlert_2.active.SetActive(true);
                timeRemaining = 3.0f;
            }
            if (provCube == false)
            {
                textAlert.active.SetActive(true);
                timeRemaining = 3.0f;
            }           
        }
           
    }
}
