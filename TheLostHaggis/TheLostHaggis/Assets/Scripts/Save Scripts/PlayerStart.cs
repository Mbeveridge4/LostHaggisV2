using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    
    private Vector2 Vector2;

    private void Awake()
    {
        Vector2 startpos = new Vector2(0, 0);
        transform.position = startpos;
    }
}
