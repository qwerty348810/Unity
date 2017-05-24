using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDis : MonoBehaviour {
    public GameObject EnableDisable;
    public void Enable()
    {
        EnableDisable.SetActive(true);
    }
    public void Disable()
    {
        EnableDisable.SetActive(false);
    }
}
