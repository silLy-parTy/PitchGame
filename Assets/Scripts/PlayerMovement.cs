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
        //Debug.Log("X: " + movement.x);

        movement.y = Input.GetAxisRaw("Vertical");
        //Debug.Log("Y: " + movement.y);

        anim.SetFloat("SpeedX", Mathf.Abs(movement.x));
        anim.SetFloat("SpeedY", Mathf.Abs(movement.y));

        if (movement.x > 0 && !facingRight)
        {
            Flip();
            
        }

        if (movement.x < 0 && facingRight)
        {
            Flip();
            
        }

        if (movement.y == 1)
        {
            anim.SetBool("isDown", false);
            anim.SetBool("isUp", true);
            

        }

        if (movement.y == -1)
        {
            anim.SetBool("isUp", false);
            anim.SetBool("isDown", true);
            
        }

        if (movement.x == 0 && movement.y == 0)
        {
            anim.SetBool("isUp", false);
            anim.SetBool("isDown", false);
            
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
