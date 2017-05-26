using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy_Cube : MonoBehaviour
{
    public Score score_to_buy;
    public NotActive cube_2;
    //public NotActive textAlert;
    //public float prov;
    void Update()
    {
        //prov = score_to_buy.scoreGlobal;
    }
    public void Button_Click()
    {       
           cube_2.active.SetActive(true);
    }
}
