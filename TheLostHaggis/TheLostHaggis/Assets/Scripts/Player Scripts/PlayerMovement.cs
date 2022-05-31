using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Coded by Mark Beveridge

    //sets the jump speed
    private readonly float jumpVelocity = 10f;
    public Rigidbody2D RigidBody;
    private bool isGrounded = true;
    // sets multipliers for the jump and fall speeds
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;


    public void Update()
    { 
        // Calls the rigidbody of the attached component to be modified
        Rigidbody2D RigidBody = GetComponent<Rigidbody2D>();

        //moves player left and right
        if (Input.GetKey(KeyCode.A))
            RigidBody.AddForce(Vector2.left);
        if (Input.GetKey(KeyCode.D))
            RigidBody.AddForce(Vector2.right);

        // additional code if we wish to add up and down movement. Disabled for child.
        // if (Input.GetKey(KeyCode.W))
        //   RigidBody.AddForce(Vector2.up);
        // if (Input.GetKey(KeyCode.S))
        //     RigidBody.AddForce(Vector2.down);

        // makes the player jump if space is pressed. Jump key is disabled after set jumps used until reset using jumpCount. 
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            RigidBody.velocity = Vector2.up * jumpVelocity;
            isGrounded = false;
        }
        // sets the multiplier when you start jumping
        if (RigidBody.velocity.y < 0)
        {
            RigidBody.velocity += (fallMultiplier - 1) * Physics2D.gravity.y * Time.deltaTime * Vector2.up;
        }
        // sets the multiplier if falling so that you fall faster
        else if (RigidBody.velocity.y > 0 && Input.GetKey(KeyCode.Space))
        {
            RigidBody.velocity += (lowJumpMultiplier - 1) * Physics2D.gravity.y * Time.deltaTime * Vector2.up;
        }
    }
        //checks for collision, if hits someting, will mark as "grounded" allowing for another jump
        private void OnCollisionEnter2D(Collision2D collision)
    {
            isGrounded = true;
    }

}
    

