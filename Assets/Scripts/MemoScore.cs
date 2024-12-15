using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MemoScore : MonoBehaviour
{
    private int[] score;
    int nowMemoNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        score = new int[100];
        score[0] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] GetScore(){
        return score;
    }

    public void SetScore(int num){
        score[nowMemoNum] = num;
        nowMemoNum++;
        if(nowMemoNum >= score.Length){
            nowMemoNum = score.Length-1;
        }
        ScoreSortDown();
    }

    public void ScoreSortDown(){
        Array.Sort(score);
        Array.Reverse(score);
    }
}
