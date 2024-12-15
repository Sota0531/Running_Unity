using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScorePrinter : MonoBehaviour
{
    private int highScore = 0;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] MemoScore memoScore;
    // Start is called before the first frame update
    void Start()
    {
        
        highScore = memoScore.GetHighScore();
        scoreText.text = "HIGH SCORE:" + highScore.ToString().PadLeft(7,'0');
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
