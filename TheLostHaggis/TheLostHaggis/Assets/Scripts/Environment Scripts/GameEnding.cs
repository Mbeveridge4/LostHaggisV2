using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Coded by Mark Beveridge

//script intended to send the player to the GameEnding scene when they are in the final trigger box and hit Enter
public class GameEnding : MonoBehaviour
{
    private bool endScene = false;

    //detects collision
    public void OnTriggerEnter2D(Collider2D collider)
    {
        //checks its the player
        if (collider.gameObject.CompareTag("Player"))
        {
            //disables player movement function
            collider.gameObject.GetComponent<PlayerMovement>().enabled = false;
            //toggles endScene bool to true
            endScene = true;
        }
    }

    public void Update()
    {

        //if player presses E - go to GameEnding
        if (Input.GetKeyDown(KeyCode.E) && endScene == true)
        {
            SceneManager.LoadScene("GameEnding");

        }
    }
}
