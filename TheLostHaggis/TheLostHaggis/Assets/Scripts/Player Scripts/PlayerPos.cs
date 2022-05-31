using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private gamemaster gm;
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<gamemaster>();
        transform.position = gm.LastCheckpointPos;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

