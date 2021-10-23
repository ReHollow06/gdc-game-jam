using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int tot_score;
    public void IncrementScore(int points)
    {
        tot_score += points;
    }
    public int GetScore()
    {
        return tot_score;
    }
}
