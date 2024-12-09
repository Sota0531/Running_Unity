using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveingController : MonoBehaviour
{
    [SerializeField] GameObject playerObj;
    private Vector3 offset;
    //カメラの初期Y座標を保持
    private float lockY;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerObj.transform.position;
        lockY = transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // カメラのY座標を固定しながら追従
        transform.position = new Vector3(playerObj.transform.position.x + offset.x, lockY,playerObj.transform.position.z + offset.z);
    }
}
