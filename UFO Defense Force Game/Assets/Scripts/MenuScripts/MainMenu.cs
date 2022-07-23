using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); // Scene to Load
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }


    public void RestartGame()
    {
        //Vars
        int gameHealth = GameObject.Find("GameController").GetComponent<GameController>().MaxHealth;
        int gameScore = GameObject.Find("GameController").GetComponent<GameController>().Score;

        GameObject.Find("GameController").GetComponent<GameController>().AdjustHealth(gameHealth);
        GameObject.Find("GameController").GetComponent<GameController>().AdjustScore(-gameScore);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameObject.SetActive(false);

    }

}
