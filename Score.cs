using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public CubeClick cubclick_1;
    public CubeClick cubclick_2;
    public CubeClick cubclick_3;
    public CubeClick cubclick_4;
    public CubeClick cubclick_5;
    public CubeClick cubclick_6;
   
    public Buy_Cube buy_cube_2;
    public Buy_Cube buy_cube_3;
    public Buy_Cube buy_cube_4;
    public Buy_Cube buy_cube_5;
    public Buy_Cube buy_cube_6;



    public float scoreGlobal;
    public Text MyText;

    void Start () {
		
	}
    

	void Update () {
        scoreGlobal = cubclick_1.score_1 + cubclick_2.score_1 + cubclick_3.score_1
            + cubclick_4.score_1 + cubclick_5.score_1 + cubclick_6.score_1
            + buy_cube_2.deletScore + buy_cube_3.deletScore
            + buy_cube_4.deletScore + buy_cube_5.deletScore + buy_cube_6.deletScore;




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
