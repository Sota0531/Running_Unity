using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoScore : MonoBehaviour
{
    public int score = -1;
    [SerializeField] TotalScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToGoStartScene(){
        score = scoreManager.GetScore();
    }

    public int GetScore(){
        return score;
    }
}
