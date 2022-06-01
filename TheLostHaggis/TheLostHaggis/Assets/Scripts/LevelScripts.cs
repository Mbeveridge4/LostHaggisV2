using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Coded by Mark Beveridge
// simple scripts to call on to use unity's Scene manager to change scene
// first is a collider option - the rest can be called directly
public class LevelScripts : MonoBehaviour
{
    
    [SerializeField] private int scene;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(scene);
        
        
    }

    // Loads the MainMenu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /// <summary>
    /// The Following Can be called for the Child Version of Levels
    /// </summary>

    public void FamilyHome()
    {
        SceneManager.LoadScene("FamilyHome");
    }

    public void TheVillage()
    {
        SceneManager.LoadScene("TheVillage");
    }

    public void Forest()
    {
        SceneManager.LoadScene("Forest");
    }

    public void ForestWolf()
    {
        SceneManager.LoadScene("ForestWolf");
    }

    public void Mountains()
    {
        SceneManager.LoadScene("Mountains");
    }

    public void Cavern()
    {
        SceneManager.LoadScene("Cavern");
    }


    /// <summary>
    /// The Following can be called for the Mother Levels
    /// </summary>

    public void MotherFamilyHome()
    {
        SceneManager.LoadScene("MotherFamilyHome");
    }

    public void MotherTheVillage()
    {
        SceneManager.LoadScene("MotherTheVillage");
    }

    public void MotherForest()
    {
        SceneManager.LoadScene("MotherForest");
    }
    public void MotherMountains()
    {
        SceneManager.LoadScene("MotherMountains");
    }

    public void MotherCavern()
    {
        SceneManager.LoadScene("MotherCavern");
    }

    public void QuitGame()
    {
        //exits the Application
        Application.Quit();
    }


}
