using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTest : MonoBehaviour
{
    private int coinScore = 1;

    void Start (){

    }

    public int GetCoinScore(){
        return coinScore;
    }

    public void DestroyThisObject(){
        Destroy(this.gameObject);
    }
}
