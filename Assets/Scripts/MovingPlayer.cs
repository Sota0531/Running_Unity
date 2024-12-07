using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rBody2D;
    private int NowJunpNum;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")||collision.gameObject.CompareTag("CanGoingGround"))
        {
            //すり抜け床を使った多段ジャンプ防止
            if(rBody2D.velocity.y <= 0){
                NowJunpNum = 0;
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position +=  Time.deltaTime * speed * transform.right;
        if (Input.GetKeyDown(KeyCode.Space) && NowJunpNum < 2)
        {
            rBody2D.velocity = Vector2.zero;
            rBody2D.AddForce(Vector2.up * 1050);
            NowJunpNum++;
        }
    }
}
