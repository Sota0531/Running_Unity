using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingStages : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject line;
    StageSpawner stageSpawner;
    // Start is called before the first frame update
    void Start()
    {
        stageSpawner = GameObject.Find("StageFactory").GetComponent<StageSpawner>();
        player = GameObject.Find("Player");
        //SetObjectCollisionActive.SetCollisionActive(false,line,this.gameObject);
    }

    

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerExit2D(Collider2D Col){
        if(Col.gameObject.CompareTag("Player")){
            stageSpawner.CreateStages(line);
        }
    }
}
