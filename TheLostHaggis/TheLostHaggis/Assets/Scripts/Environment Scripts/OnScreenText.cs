using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScreenText : MonoBehaviour
{
    public string text;
    //coded by Charlie

    //if this script is on an object with a collider display the gui
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.tag == "Player")
        {
            OnGUI();
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 200, 20), text);
    }

}
