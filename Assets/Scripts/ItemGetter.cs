using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemGetter : MonoBehaviour
{
    [SerializeField] GameObject scoreText;
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.TryGetComponent<ICoin>(out var coin)){
            int num = coin.GetCoinScore();
            coin.DestroyThisObject();
            scoreText.GetComponent<TotalScoreManager>().AddScore(num);
        }
    }
}
