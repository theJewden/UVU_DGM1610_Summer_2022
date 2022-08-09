using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehavior : MonoBehaviour // Should've been HighscoreBehavior with all the difference in here
{
    //Create Vars
    private int score;
    private int highScore;
    public GameObject gameData;
    public Text scoreText;
    public Text highScoreText;

    private void Awake()
    {
        //Find our GameData object when this object is created
        gameData = GameObject.Find("GameData");
    }

    private void Start()
    {
        //Get values from Gamedata
        score = gameData.GetComponent<GameData>().Score;
        highScore = gameData.GetComponent<GameData>().highScoreInt;

        //Update the text
        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;
    }

    public void UpdateScoreText(int value)
    {

        // Adjust Score
        gameData.GetComponent<GameData>().AdjustScore(value);

        //Get values from GameData
        score = gameData.GetComponent<GameData>().Score;
        highScore = gameData.GetComponent<GameData>().highScoreInt;

        //Update the text
        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;

    }
}
