
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

//Purpose to save player position data in an external binary file - and decode and return the data depending on which function is used.
public static class SaveSystem
{
    //coded by Mark Beveridge

    //saves the data
    public static void SavePlayer (Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        //sets the destination path
        string path = Application.persistentDataPath + "/player.save";
        //sets the data stream mode to create a file
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);
        //tells the formatter to convrt the data to binary and send it to the file 
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer ()
    {
        // sets the data load destination
        string path = Application.persistentDataPath + "/player.save";
        //if theres a file there
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            //decodes the binary into the format of the PlayerData Method
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;

        }
        //if no file there - returns nothing and puts a message in the debug log
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }


}

