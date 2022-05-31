using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeToggle : MonoBehaviour
{
    public void MuteAudio(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
