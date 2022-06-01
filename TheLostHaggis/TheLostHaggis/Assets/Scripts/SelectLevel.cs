using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Coded by Sam Stewart
// a simple animator toggle for the Level select menu
public class SelectLevel : MonoBehaviour
{
    //choose an animator in Unity
    public Animator animator;

    public void OpenMenu()
    {
        //sets the boolean in the attached animator to true to trigger open animation
        animator.SetBool("IsOpen", true);
    }
    public void CloseMenu()
    {
        //sets the boolean in the animator to false to trigger close animation
        animator.SetBool("IsOpen", false);
    }
}
