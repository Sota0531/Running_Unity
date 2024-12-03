using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OldStageDestroyer : MonoBehaviour
{
    private Collider2D _collider;
    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit2D(Collider2D col){
        GameObject gameObject= col.gameObject;
        //Destroy(gameObject);
        Destroy(col.gameObject.transform.parent.gameObject);
    }
}
