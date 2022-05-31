using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Player : MonoBehaviour
{
    // coded by Mark Beveridge

    public int level = 1;
    public Rigidbody2D RigidBody;

    // runs the Save element of SaveSystem
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        
    }

    //runs the load element of the save system.
    public void LoadPlayer()
    {
        
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.level;

        Vector3 position;
        //changes the current position to the data loaded from the save using the float array to set each axis
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
        

    }
    public void SaveScene()
    {
        //saves the current scene to playerprefs
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadScene()
    {
        //loads the last saved scene from playerprefs
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));      
    }


}
