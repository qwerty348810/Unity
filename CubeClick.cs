using System.Collections;
using UnityEngine;

public class CubeClick : MonoBehaviour
{
    public GameObject EnableDisable;
    bool click = true; 

    
    private void OnMouseDown(){
        if (click == true)
        {
            EnableDisable.SetActive(true);
            click = false;
        }
        if (click == false)
        {
            EnableDisable.SetActive(false);
            click = true;
        }
    }
}
