﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class ModeMenuManager : MonoBehaviour {


    //method to be called when we press addition button
    public void AdditionMode()
    {

        GameManager.singleton.currentMode = 1;
        // Application.LoadLevel("GamePlay"); // use this for unity below 5.3 version
        SceneManager.LoadScene("GamePlay");

    }

    public void SubtractionMode()
    {
        GameManager.singleton.currentMode = 2;
        // Application.LoadLevel("GamePlay"); // use this for unity below 5.3 version
        SceneManager.LoadScene("GamePlay");
    }

    public void MultiplicationMode()
    {
        GameManager.singleton.currentMode = 3;
        // Application.LoadLevel("GamePlay"); // use this for unity below 5.3 version
        SceneManager.LoadScene("GamePlay");
        
    }

    public void DivisionMode()
    {
        GameManager.singleton.currentMode = 4;
        // Application.LoadLevel("GamePlay"); // use this for unity below 5.3 version
        SceneManager.LoadScene("GamePlay");
        
    }

    public void MixMode()
    {
        GameManager.singleton.currentMode = 5;
        // Application.LoadLevel("GamePlay"); // use this for unity below 5.3 version
        SceneManager.LoadScene("GamePlay");
        
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
        // Application.LoadLevel("GamePlay"); // use this for unity below 5.3 version
        
    }
}