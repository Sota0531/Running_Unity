using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] stages;
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateStages(GameObject gameObject){
        GameObject stage = stages[Random.Range(0, stages.Length)];
        Instantiate(stage, gameObject.transform.position, Quaternion.identity);
    }
}
