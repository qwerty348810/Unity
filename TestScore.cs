using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScore : MonoBehaviour
{
    private CubeClick cubclick_1;
    private CubeClick cubclick_2;
    public Score score;
    
    private Player player = new Player();
    void Start()
    {
        // exemle #1 
        // player.Power = 150;
        // player.Power = 150;
        //Debug.Log("Score: " + player.GetPower());
        Debug.Log("Score: " + score.GetScoreGlobal());
    }
    void Update()
    {
        //player.Power = cubclick_1.score_1; //+ cubclick_2.score_1;
        Debug.Log("Score: " + score.GetScoreGlobal());
    }
}
	public class Player
    {
    // exemle #2 
    // private int power = 150;
    private float power;
        public float Power
        {
            get {
                return power;
            }
            set {
                power = value;
            }
        }
    
    public float GetPower()
    {
        return this.power;
    }
	
}
