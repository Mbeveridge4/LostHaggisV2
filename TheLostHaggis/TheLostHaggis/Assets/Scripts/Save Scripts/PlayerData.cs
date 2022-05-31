using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    //stores the data to be saved
    public int level;
    public float[] position;
  

 

    public PlayerData (Player player)
    {
        level = player.level;
        //converts the Vector position into a float array to make it possible to store as binary
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;


    }

}
