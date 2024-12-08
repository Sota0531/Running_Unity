using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemGetter : MonoBehaviour
{
    [SerializeField] Rigidbody2D rBody2D;
    [SerializeField] GameObject scoreText;
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Coins")){
            int num = col.gameObject.GetComponent<ICoin>().GetCoinScore();
            col.gameObject.GetComponent<ICoin>().DestroyThisObject();
            scoreText.GetComponent<TotalScoreManager>().AddScore(num);
        }
    }
}
