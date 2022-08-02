using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int highScore;
    public GameObject gameData;

    private void Awake()
    {
        gameData = GameObject.Find("GameData");
        UpdateOnGameStart();
    }

    public void UpdateOnGameStart() // Update the highscore on game startup
    {
        gameData.GetComponent<GameData>().highScoreInt = highScore;
    }


    public void UpdateHighScore()
    {
        int num = gameData.GetComponent<GameData>().Score;

        if(highScore >= num)
        {
            return;
        } else
        {
            highScore = num;
            gameData.GetComponent<GameData>().highScoreInt = highScore;
        }
    }
}
