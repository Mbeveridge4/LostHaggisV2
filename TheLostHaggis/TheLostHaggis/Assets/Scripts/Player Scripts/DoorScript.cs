using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This Script will teleport the player to the other side of the door when the correct key is pressed 
/// and the player is within the collider area.
/// </summary>
public class DoorScript : MonoBehaviour
{
    private Transform PlayerTransform;
    [SerializeField] private int NewPosX;
    [SerializeField] private int NewPosY;


    public void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //change the players position to the new position
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
