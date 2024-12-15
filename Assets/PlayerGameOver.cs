using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameOver : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] TotalScoreManager scoreManager;
    private MemoScore memoScore;
    // Start is called before the first frame update
    void Start()
    {
        memoScore = GameObject.Find("SceneScoreManager").GetComponent<MemoScore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver(){
        memoScore.SetScore(scoreManager.GetScore());
        SceneManager.LoadScene(1);
    }
}
