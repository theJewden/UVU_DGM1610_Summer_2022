using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverBehavior : MonoBehaviour
{
    public UnityEvent gameOver;
    public UnityEvent gameResume;


    public void GameOver()
    {
        Time.timeScale = 0;
        gameOver.Invoke();

    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        gameResume.Invoke();
    }

}
