﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// This script manages the game play GUI
/// </summary>

public class GUIManager : MonoBehaviour
{

    //ref to the score
    public Text inGameScoreText;

    //ref to score text in game over panel
    public Text scoreOverText;
    //ref to hiscore text in game over panel
    public Text hiScoreOverText;

    //ref to game over panel
    public GameObject gameOverMenu;
    //ref to game over panel animator
    public Animator gameOverAnim;



    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //we check for the game manager
        if (GameManager.singleton != null)
        {
            //and keep updating score value
            inGameScoreText.text = GameManager.singleton.currentScore.ToString();
        }

        //we check if the game is over 
        if (GameManager.singleton.isGameOver == true)
        {
            
            //we update the score text and hi score text
            scoreOverText.text = "" + GameManager.singleton.currentScore;

            hiScoreOverText.text = "" + GameManager.singleton.hiScore;

            //we play the slideIn animation
            gameOverAnim.Play("SlideIn");
        }
    }

    //ref method to retry button
    public void RetryButton()
    {
        SceneManager.LoadScene("GamePlay");
        GameManager.singleton.isGameOver = false;
    }
  
    //ref method for home button
    public void HomeButton()
    {
        SceneManager.LoadScene("MainMenu");
        GameManager.singleton.isGameOver = false;
    }
}




