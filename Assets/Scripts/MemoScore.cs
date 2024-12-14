using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MemoScore : MonoBehaviour
{
    private int[] score;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        score = new int[100];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] GetScore(){
        return score;
    }

    public void SetScore(int i ,int num){
        if(i > score.Length){
            score[i-score.Length] = num;
            Debug.Log("配列範囲外");
        }else{
            score[i] = num;
        }
    }

    public void ScoreSortDown(){
        Array.Sort(score);
        Array.Reverse(score);
    }
}
