using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Coded by Liam Mead
    public Vector3 originalPos;
    private gamemaster gm;

    private void Awake()
    {
       originalPos = gameObject.transform.position;

    }
    private void OnCollisionEnter2D (Collision2D other)
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<gamemaster>();

        // detects if the object collided with has either the enemy or Killbox tags
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Killbox"))
        {
            //writes in the debug log that the reset happened
            Debug.Log("Collision Reset occurred");
          //  gameObject.transform.position = originalPos;
          //reloads the scene and puts the player back to the most recent checkpoint in the scene.
            transform.position = gm.LastCheckpointPos;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
