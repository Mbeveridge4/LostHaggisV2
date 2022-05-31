using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{
    public Animator animator;

    public void OpenMenu()
    {
        animator.SetBool("IsOpen", true);
    }
    public void CloseMenu()
    {
        animator.SetBool("IsOpen", false);
    }
}
