using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinTest : MonoBehaviour, ICoin
{
    private int coinScore = 1;

    public int GetCoinScore(){
        return coinScore;
    }

    public void DestroyThisObject(){
        Destroy(this.gameObject);
    }
}
