using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScripts : MonoBehaviour
{
    [SerializeField] private int scene;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(scene);
    }

    // Loads the MainMenu
    void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    /// <summary>
    /// The Following Can be called for the Child Version of Levels
    /// </summary>

    void FamilyHome()
    {
        SceneManager.LoadScene("FamilyHome");
    }

    void TheVillage()
    {
        SceneManager.LoadScene("TheVillage");
    }

    void Forest()
    {
        SceneManager.LoadScene("Forest");
    }

    void ForestWolf()
    {
        SceneManager.LoadScene("ForestWolf");
    }

    void Cavern()
    {
        SceneManager.LoadScene("Cavern");
    }


    /// <summary>
    /// The Following can be called for the Mother Levels
    /// </summary>

    void MotherFamilyHome()
    {
        SceneManager.LoadScene("MotherFamilyHome");
    }

    void MotherTheVillage()
    {
        SceneManager.LoadScene("MotherTheVillage");
    }

    void MotherForest()
    {
        SceneManager.LoadScene("MotherForest");
    }

    void MotherCavern()
    {
        SceneManager.LoadScene("MotherCavern");
    }



}
