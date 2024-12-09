using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.TryGetComponent<MovingPlayer>(out var movingPlayer)){
            //Destroy(col.gameObject);
        }
    }
}
