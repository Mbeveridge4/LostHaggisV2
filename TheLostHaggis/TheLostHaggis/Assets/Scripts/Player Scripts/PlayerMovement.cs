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
        //sets mx float to the horizontal player input from unity (A,D or left or right keys)
        mx = Input.GetAxisRaw("Horizontal");

        //moves you left or right based off horizontal input
        Vector2 movement = new Vector2(mx * moveSpeed, rb.velocity.y);
        rb.velocity = movement;
        //checks if player is colliding with something and space is pressed
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //makes the player model go up
            rb.velocity = Vector2.up * jumpVelocity;
            isGrounded = false;
           
        }
       

    }

   
      
        //checks for collision, if hits someting, will mark as "grounded" allowing for another jump
        private void OnCollisionEnter2D(Collision2D collision)
    {
            isGrounded = true;
    }

}
    

