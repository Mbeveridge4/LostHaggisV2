using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Coded by Mark Beveridge

    [SerializeField]private float jumpVelocity = 10f;
    [SerializeField] private float moveSpeed;
    public Rigidbody2D rb;
    private bool isGrounded = true;
    private float mx;

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.velocity = Vector2.up * jumpVelocity;
            isGrounded = false;
           
        }
        // sets the multiplier when you start jumping
        Vector2 movement = new Vector2(mx * moveSpeed, rb.velocity.y);
        rb.velocity = movement;

    }

   
      
        //checks for collision, if hits someting, will mark as "grounded" allowing for another jump
        private void OnCollisionEnter2D(Collision2D collision)
    {
            isGrounded = true;
    }

}
    

