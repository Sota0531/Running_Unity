using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OldStageDestroyer : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D col){
        //GameObject gameObject= col.gameObject;
        //Destroy(gameObject);
        Destroy(col.gameObject.transform.parent.gameObject);
    }
}
