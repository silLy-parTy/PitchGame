using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPushing : MonoBehaviour
{
    //Declare Variables
    public float moveSpeed = 0.005f;

    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        rb.MovePosition(rb.position + movement * moveSpeed);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        rb.MovePosition(rb.position + movement * 0);
    }
}
