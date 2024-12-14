using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OldStageDestroyer : MonoBehaviour
{
    [SerializeField] GameObject playerObj;
    private Vector3 offset;
    void Start(){
        offset = transform.position - playerObj.transform.position;
    }
    private void OnTriggerExit2D(Collider2D col){
        //GameObject gameObject= col.gameObject;
        //Destroy(gameObject);
        Destroy(col.gameObject.transform.parent.gameObject);
    }
    void LateUpdate()
    {
        // カメラのY座標を固定しながら追従
        transform.position = new Vector3(playerObj.transform.position.x + offset.x, playerObj.transform.position.y + offset.y,playerObj.transform.position.z + offset.z);
    }
}
