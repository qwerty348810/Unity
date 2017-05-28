using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public CubeClick cubclick_1;
    public CubeClick cubclick_2;

    public Buy_Cube buy_cube;


    public float scoreGlobal;
    public Text MyText;

    void Start () {
		
	}
    

	void Update () {
        scoreGlobal = cubclick_1.score_1 + cubclick_2.score_1 + buy_cube.deletScore;
        
        


    }
    void OnGUI()
    {       
        MyText.text = "Score: " + scoreGlobal.ToString();
    }



    
    public float ScoreGlobal
    {
        get
        {
            return scoreGlobal;
        }
        set
        {
            scoreGlobal = value;
        }
    }

    public float GetScoreGlobal()
    {
        return this.scoreGlobal;
    }
}
