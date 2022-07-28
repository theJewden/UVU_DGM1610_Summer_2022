using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ItemSpawner : MonoBehaviour
{

    public struct Spawnable
    {
        public GameObject gameObject;
        public float weight;
    }
    public List<Spawnable> items = new List<Spawnable>();

    [HideInInspector]
    public float totalWeight;

    private void Awake()
    {
        totalWeight = 0f;
        foreach(var spawnable in items)
        {
            totalWeight += spawnable.weight;
        }
    }

    public void Start()
    {
       float pick = Random.value * totalWeight;
       int chosenindex = 0;
       float cumaulativeWeight = items[0].weight;

        while(pick > cumaulativeWeight && chosenindex < items.Count - 1)
        {
            chosenindex++;
            cumaulativeWeight += items[chosenindex].weight;
        }
        GameObject i = Instantiate(items[chosenindex].gameObject, transform.position, Quaternion.identity) as GameObject;
    }
}
