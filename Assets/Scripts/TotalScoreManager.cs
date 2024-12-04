using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalScoreManager : MonoBehaviour
{
    private int Score = 0;

    public void AddScore(int addnum){
        Score += addnum;
    }

    public int GetScore(){
        return Score;
    }
}
