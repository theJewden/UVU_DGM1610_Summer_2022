using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreController : MonoBehaviour
{
    public GameObject gameData;

    private void Start()
    {
        gameData = GameObject.Find("GameData");
    }

    public void UpdateHighScore(int num)
    {
        gameData.GetComponent<TextBehavior>().UpdateScoreText(num);
    }

    public void UpdateHighScore()
    {

    }

}
