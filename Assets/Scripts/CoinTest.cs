using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTest : MonoBehaviour
{
    //private int coinScore = 1;

    void Start (){

    }

    void OnTriggerEnter2D(Collider2D col){
        Destroy(this.gameObject);
        
    }
}
