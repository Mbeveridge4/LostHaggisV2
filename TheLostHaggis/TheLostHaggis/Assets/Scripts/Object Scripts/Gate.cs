using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    PlayerInteraction Interact;

    private void Awake()
    {
        Interact = GameObject.Find("Player").GetComponent<PlayerInteraction>();
    }
    private void Update()
    {
        if(Interact.Interact == true)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
