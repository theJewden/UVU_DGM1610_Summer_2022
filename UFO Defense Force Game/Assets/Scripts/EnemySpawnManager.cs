using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; // Array to store UFO ships
    public int ufoIndex;
    private float ufoSpawnX;
    private float ufoSpawnXRange = 32.0f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }

    void Update()
    {
       
    }

    void SpawnRandomUFO()
    {
        ufoIndex = Random.Range(0, ufoPrefabs.Length);
        ufoSpawnX = Random.Range(-ufoSpawnXRange, ufoSpawnXRange);
        Instantiate(ufoPrefabs[ufoIndex], new Vector3(ufoSpawnX, 0, 20), ufoPrefabs[ufoIndex].transform.rotation);
    }
}
