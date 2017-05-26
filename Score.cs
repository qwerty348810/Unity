using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public CubeClick cubclick_1;
    public CubeClick_2 cubclick_2;
    public float scoreGlobal;
    public Text MyText;

    void Start () {
		
	}
    

	void Update () {
        scoreGlobal = cubclick_1.score_1 + cubclick_2.score_2;
    }
    void OnGUI()
    {       
        MyText.text = "Score: " + scoreGlobal.ToString();
    }
}
