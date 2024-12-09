using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveingController : MonoBehaviour
{
    [SerializeField] GameObject playerObj;
    private Vector3 offset;
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
        transform.position = playerObj.transform.position + offset;
        transform.position = new Vector3(transform.position.x, lockY,transform.position.z);
    }
}
