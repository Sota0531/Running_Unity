using UnityEngine;
public class FloorGoing : MonoBehaviour
{
    private GameObject player;
    [SerializeField] Collider2D _Collider;
    //床とプレイヤーが接触していないかを記録する変数
    [SerializeField] bool nowGoing;
    void Start()
    {
        player = GameObject.Find("Player");
        //_Collider = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        
        nowGoing = true;
    }
    private void OnTriggerExit2D(Collider2D collision){
        nowGoing = false;
        SetObjectCollisionActive.SetCollisionActive(true,player,this.gameObject);
    }
    void Update()
    {
        //下入力ですり抜けるように
        if (Input.GetKey(KeyCode.DownArrow)){
            SetObjectCollisionActive.SetCollisionActive(false,player,this.gameObject);
        }
        if(Input.GetKeyUp(KeyCode.DownArrow)){
            //接触中は判定を操作しない
            if(!nowGoing){
                SetObjectCollisionActive.SetCollisionActive(true,player,this.gameObject);
            }
        }
    }
}