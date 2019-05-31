using UnityEngine;
using UnityEngine.UI;

// This script manages our time for each question

public class TimerBarController : MonoBehaviour {

    public static TimerBarController instance;

    
    public Transform fillBar;

    [HideInInspector]public float currentAmount;

    private float timeT;

	// Use this for initialization
	void Start ()
    {
        timeT = GameManager.singleton.timeForQuestion;

        GameManager.singleton.isGameOver = false;

        currentAmount = 1;
    }

    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Update()
    {
     
        currentAmount  -= (timeT) * Time.deltaTime;

        fillBar.GetComponent<Image>().fillAmount = currentAmount;

        if (currentAmount <= 0)
        {
            //if the fill become zero , means the time is over we declare game over
            GameManager.singleton.isGameOver = true;
        }

    }

}
