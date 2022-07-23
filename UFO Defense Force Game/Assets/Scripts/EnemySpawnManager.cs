using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array to store UFO ships
    public GameObject gameController;
    public int ufoIndex;
    private bool difficultyTwo = false;
    private bool difficultyThree = false;
    private float ufoSpawnX;
    private float ufoSpawnXRange = 20.0f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
        gameController = GameObject.Find("GameController");
    }

    private void Update()
    {
        if (gameController.GetComponent<GameController>().Score > 1000 && !difficultyTwo)
        {
            InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
            difficultyTwo = true;
            Debug.Log("Diffulty 2 Unlocked");
        }

        if(gameController.GetComponent<GameController>().Score > 2000 && !difficultyThree)
        {
            InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
            difficultyThree = true;
            Debug.Log("Diffulty 3 Unlocked");
        }
    }

    void SpawnRandomUFO()
    {
        ufoIndex = Random.Range(0, ufoPrefabs.Length);
        ufoSpawnX = Random.Range(-ufoSpawnXRange, ufoSpawnXRange);
        Instantiate(ufoPrefabs[ufoIndex], new Vector3(ufoSpawnX, 0, 20), ufoPrefabs[ufoIndex].transform.rotation);
    }
}
