using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MemoScore : MonoBehaviour
{
    public int[] score = new int[100];
    int nowMemoNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("OnlyScoreManager");
        if (objs.Length > 1){
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int[] GetScore(){
        ScoreSortDown();
        return score;
    }
    public int GetHighScore(){
        ScoreSortDown();
        return score[0];
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
