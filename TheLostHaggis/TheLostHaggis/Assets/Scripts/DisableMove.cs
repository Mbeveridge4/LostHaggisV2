using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisableMove : MonoBehaviour
{
    
    private bool endScene;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            collider.gameObject.GetComponent<PlayerMovement>().enabled = false;
            endScene = true;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && endScene==true)
        {
            SceneManager.LoadScene("MotherFamilyHome");
        }
    }
}