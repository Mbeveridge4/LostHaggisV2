using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This Script will teleport the player to the other side of the door when the correct key is pressed 
/// and the player is within the collider area.
/// </summary>
public class DoorScript : MonoBehaviour
{
    //used in the UI to set the target position to move to on command
    [SerializeField] private Vector3 targetPosition;
    //used in the UI to identify which target to move
    [SerializeField] private bool isPlank;
    [SerializeField] private bool isDoor;
    [SerializeField] private bool isLadder;

    
    public void OnTriggerStay2D(Collider2D collider)
    {
        // if the player is still colliding, and the player
        if (collider.gameObject.CompareTag("Player"))
        {
            if (isDoor || isLadder)
            {
                //change the players position to the new position
                collider.gameObject.transform.position = targetPosition;
            }

            if (isPlank)
            {
                //change the position of the object the script is attached to, to the new position
                gameObject.transform.position = targetPosition;
            }

            //66.26 -0.16
            //75.14
        }

    }
   
  
}
