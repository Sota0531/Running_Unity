using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTest : MonoBehaviour
{
    [SerializeField] int CoinScore;

    void OnTriggerEnter2D(Collider2D col){
        Destroy(this.gameObject);
    }
}
