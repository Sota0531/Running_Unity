using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemGetter : MonoBehaviour
{
    [SerializeField] GameObject scoreText;
    [SerializeField] GameObject HPText;
    [SerializeField] GameObject Player;
    void OnTriggerEnter2D(Collider2D col){
        //コイン取得処理
        if(col.gameObject.TryGetComponent<ICoin>(out var coin)){
            int num = coin.GetCoinScore();
            coin.DestroyThisObject();
            scoreText.GetComponent<TotalScoreManager>().AddScore(num);
        }
        //障害物激突処理
        if(col.gameObject.TryGetComponent<IObstacle>(out var obstacle)){
            int num = obstacle.DecreaseHP();
            HPText.GetComponent<PlayerLifeManager>().RemoveLife(num);
            SetObjectCollisionActive.SetCollisionActive(false,Player,col.gameObject);
        }
    }
}
