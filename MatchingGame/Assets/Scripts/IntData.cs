using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int highScore;
    public GameObject gameData;


    public void UpdateHighScore()
    {
        gameData = GameObject.Find("GameData");
        int num = gameData.GetComponent<GameData>().Score;

        if(highScore >= num)
        {
            gameData.GetComponent<GameData>().highScoreInt = highScore;
        } else
        {
            highScore = num;
            gameData.GetComponent<GameData>().highScoreInt = highScore;
        }
    }
}
