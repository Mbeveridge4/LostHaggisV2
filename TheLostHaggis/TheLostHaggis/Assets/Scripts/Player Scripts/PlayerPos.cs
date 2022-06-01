using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//coded by Liam Mead
public class PlayerPos : MonoBehaviour
{
    private gamemaster gm;
    private void Start()
    {
        //when called - resets the player position to the last checkpoint position
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<gamemaster>();
        transform.position = gm.LastCheckpointPos;
    }

    private void Update()
    {
        //for testing purposes - if z is pressed - reset the scene
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

