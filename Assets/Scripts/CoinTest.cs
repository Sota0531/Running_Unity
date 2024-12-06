using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinTest : MonoBehaviour
{
    [SerializeField] int CoinScore;
    // Start is called before the first frame update
    void Start()
    {
        //_collider2D = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        Destroy(this.gameObject);
    }
}
