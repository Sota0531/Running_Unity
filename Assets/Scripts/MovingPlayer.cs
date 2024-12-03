using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    private Rigidbody2D rBody2D;
    [SerializeField] float speed;
    private int NowJunpNum;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")||collision.gameObject.CompareTag("CanGoingGround"))
        {
            NowJunpNum = 0;
        }
    }

    private void Start()
    {
        rBody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += speed * transform.right * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && NowJunpNum < 2)
        {
            rBody2D.velocity = Vector2.zero;
            rBody2D.AddForce(Vector2.up * 1050);
            NowJunpNum++;
        }
    }
}
