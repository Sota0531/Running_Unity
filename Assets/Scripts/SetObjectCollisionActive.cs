using UnityEngine;
public class SetObjectCollisionActive: MonoBehaviour
{
    /// <summary>
    /// 2つのオブジェクト間の当たり判定を変更するメソッド
    /// </summary>
    /// <param name="obj1">
    /// 判定を変更したいゲームオブジェクトを渡してください
    /// </param>
    /// <param name="obj2">判定を変更したいゲームオブジェクトを渡してください</param>
    /// <param name="canCollision">trueなら当たり判定を有効化し、falseなら無効化します</param>
    public static void SetCollisionActive(bool canCollision, GameObject obj1,GameObject obj2){
        var obj1Col = obj1.GetComponent<Collider2D>();
        var obj2Col = obj2.GetComponent<Collider2D>();
        if (obj1Col == null){
            Debug.Log("1st obj col is null");
        }
        if (obj2Col == null){
            Debug.Log("2nd obj col is null");
        }
        if(canCollision){
            Physics2D.IgnoreCollision(obj1Col,obj2Col,false);
        }else{
            Physics2D.IgnoreCollision(obj1Col,obj2Col,true);
        }
    }
}
