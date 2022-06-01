using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Coded by Liam Mead
public class Checkpoint : MonoBehaviour
{
    private gamemaster gm;

    private void Start()
    {
        //sets the gamemaster to the gm instance already in game
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<gamemaster>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //if the player collides with this object, updates the LastCheckpointPos to current position
            gm.LastCheckpointPos = transform.position;
        }
    }
}
