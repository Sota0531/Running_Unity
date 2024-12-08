using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCoin : MonoBehaviour,ICoin
{
    private int coinScore = 5;
    public int GetCoinScore(){
        return coinScore;
    }
    public void DestroyThisObject(){
        Destroy(this.gameObject);
    }
}
