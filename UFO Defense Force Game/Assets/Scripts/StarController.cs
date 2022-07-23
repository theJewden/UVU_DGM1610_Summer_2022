using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    private float starSpawnRate = .1f;
    public GameObject star;
    private float location;
    private float locationMax = 27f;


    private void Start()
    {
        InvokeRepeating("SpawnStar", starSpawnRate, starSpawnRate);
    }

    private void Update()
    {
        location = Random.Range(-locationMax, locationMax);
    }


    public void SpawnStar()
    {
        Instantiate(star, new Vector3(location, 0, 22), star.transform.rotation);
    }
}
