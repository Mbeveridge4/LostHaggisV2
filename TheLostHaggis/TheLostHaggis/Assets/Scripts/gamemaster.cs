using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//coded by Liam Mead
public class gamemaster : MonoBehaviour
{
    private static gamemaster instance;
    //stores the last checkpoint position
    public Vector2 LastCheckpointPos;
    private void Awake()
    {
        //if there isnt an instance of the gamemaster
        if (instance == null)
        {
            //make this the game master
            instance = this;
            //dont destroy this on load
            DontDestroyOnLoad(instance);
        }
        else
        {
            //destroy this
            Destroy(gameObject);
        }
    }
}
