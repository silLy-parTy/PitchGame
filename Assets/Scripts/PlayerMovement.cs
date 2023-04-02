using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Declare Variables
    public float moveSpeed = 1f;

    public bool facingRight = true;

    public Rigidbody2D rb;
    public Animator anim;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //Debug.Log(movement.y);

        anim.SetFloat("SpeedX", Mathf.Abs(movement.x));

        if (movement.x > 0 && !facingRight)
        {
            Flip();
        }

        if (movement.x < 0 && facingRight)
        {
            Flip();
        }

        

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed);
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}
