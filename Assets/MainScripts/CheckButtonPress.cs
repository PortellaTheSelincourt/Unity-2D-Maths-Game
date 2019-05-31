using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// This script help to identify the button tag and increases score if button is correct

public class CheckButtonPress : MonoBehaviour {

    private Button thisButton;
    private int score;
    private int hiScore;
    public Image backgroundSprite;

    void Start()
    {
        //at start, score = 0;
        score = 0;
        thisButton = GetComponent<Button>();
        hiScore = GameManager.singleton.hiScore;
    }

    void Update()
    {
       
         score = GameManager.singleton.currentScore;
        if (hiScore < score)
        {         
            hiScore = score;
            GameManager.singleton.hiScore = hiScore;
            GameManager.singleton.Save();
        }
    }

    public void checkTheTextofButton()
    {
        
        if (gameObject.CompareTag( MathsAndAnswerScript.instance.tagOfButton))
        {
            //if they are same we increase the score and reset the time
            score++;
            TimerBarController.instance.currentAmount = 1;
            GameManager.singleton.currentScore = score;
            
        }
        else
        {
            //if not we do not increase the score and do not reset the time         
            StartCoroutine(ColorChange());
            
        }

        //after we have answered the question we call the maths problem method to create new question
        MathsAndAnswerScript.instance.MathsProblem();
        
    }

    //its an ienumerator it is used when we need to do something with respect to time
    IEnumerator ColorChange()
    {
        //here we change the color of background for 0.05 sec of 1 sec and then we reset it to its original color
        backgroundSprite.color = new Color32(221, 127, 127, 255);

        yield return new WaitForSeconds(0.05f);

        backgroundSprite.color = new Color32(255, 255, 255, 255);
    }

}
