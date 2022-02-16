using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public float highscore=0;

 

    void ScoreComparator(int newScore)
    {
        if(highscore < newScore)
        {
            highscore = newScore;
        }
        else
        {

        }
    
    
    }

}
