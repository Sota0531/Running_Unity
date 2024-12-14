using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemGetter : MonoBehaviour
{
    [SerializeField] TotalScoreManager _scoreManager;
    [SerializeField] PlayerLifeManager _lifeManager;
    void OnTriggerEnter2D(Collider2D col){
        //コイン取得処理
        if(col.gameObject.TryGetComponent<ICoin>(out var coin)){
            int num = coin.GetCoinScore();
            coin.DestroyThisObject();
            _scoreManager.AddScore(num);
        }
        //障害物激突処理
        if(col.gameObject.TryGetComponent<IObstacle>(out var obstacle)){
            int num = obstacle.DecreaseHP();
            _lifeManager.RemoveLife(num);
            SetObjectCollisionActive.SetCollisionActive(false,this.gameObject,col.gameObject);
        }
    }
}
