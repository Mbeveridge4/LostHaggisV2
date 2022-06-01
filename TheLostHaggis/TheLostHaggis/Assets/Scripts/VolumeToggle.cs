using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//coded by Sam Stewart
//simple mute audio script
public class VolumeToggle : MonoBehaviour
{
    public void MuteAudio(bool muted)
    {
        if (muted)
        {
            //silences listener
            AudioListener.volume = 0;
        }
        else
        {
            //sets listener to max
            AudioListener.volume = 1;
        }
    }
}
