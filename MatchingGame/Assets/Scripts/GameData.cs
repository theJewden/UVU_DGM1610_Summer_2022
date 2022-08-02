using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameData : MonoBehaviour
{
    // Private data
    private int score = 0;

    //Public data
    public int Score;
    public int highScoreInt;

    //Public Game Objects
    public UnityEvent highScore;
    public UnityEvent startGame;

    private void Awake()
    {

        //Do our start game unity event
        startGame.Invoke();
    }


    public void Update()
    {
        //Set our public integer to equal our private integer
        if (Score != score)
        {
            Score = score;
        }

        if (score <= -50)
        {
            gameObject.GetComponent<GameOverBehavior>().GameOver();
        }
        

    }

    public void AdjustScore(int value)
    {

        //Update score
        score += value;
        Score = score;

        //Do our update highscore unity event
        highScore.Invoke();
        
    }

    public void ResetScore()
    {

        //Do our update highscore unity event
        highScore.Invoke();


        //Reset Score
        score = 0;
        Score = score;

        //Update Text
        gameObject.GetComponent<TextBehavior>().UpdateScoreText(0);

    }
}
