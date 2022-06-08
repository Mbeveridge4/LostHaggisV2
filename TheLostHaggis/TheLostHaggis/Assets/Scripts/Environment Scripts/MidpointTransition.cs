using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MidpointTransition : MonoBehaviour
{
   

   
    
    
    //detects collision
    public void OnTriggerEnter2D(Collider2D collider)
    {
        //checks its the player
        if (collider.gameObject.CompareTag("Player"))
        {
            //disables player movement function
            collider.gameObject.GetComponent<PlayerMovement>().enabled = false;
            //toggles endScene bool to true

        }
    }

    public void Update()
    {

        //if player presses E - go to GameEnding
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("MotherFamilyHome");
            
        }
    }
}