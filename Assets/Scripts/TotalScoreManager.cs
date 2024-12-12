using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TotalScoreManager : MonoBehaviour
{
    private int Score;
    private TMP_Text _scoreText;

    void Start(){
        Score = 0;
        _scoreText = GetComponent<TMP_Text>();
        _scoreText.text = "score:" + Score.ToString().PadLeft(7, '0');
    }

    public void AddScore(int addnum){
        Score += addnum;
        _scoreText.text = "score:" + Score.ToString().PadLeft(7, '0');
    }

    public int GetScore(){
        return Score;
    }
}
