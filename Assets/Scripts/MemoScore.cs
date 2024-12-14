using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoScore : MonoBehaviour
{
    public int score = -1;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetScore(){
        return score;
    }

    public void SetScore(int score){
        this.score = score;
    }
}
