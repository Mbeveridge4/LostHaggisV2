using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public bool Interact = false;
    
    // Start is called before the first frame update
    
    void Update()
    {
        if(Input.GetKey(KeyCode.K))
        {
            Interact = true;
        }

        
    }
}
