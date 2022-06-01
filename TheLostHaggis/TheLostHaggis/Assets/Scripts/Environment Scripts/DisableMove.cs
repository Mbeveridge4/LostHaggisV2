using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// code is intended to stop the player movement from function upon entering a trigger box 
/// </summary>
public class DisableMove : MonoBehaviour
{
    
    private bool endScene;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            collider.gameObject.GetComponent<PlayerMovement>().enabled = false;
            
        }
    }

    //when E key is pressed - move to MotherFamilyHome scene.

    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && endScene == true)
        {
            SceneManager.LoadScene("MotherFamilyHome");
            
        }
    }
}
