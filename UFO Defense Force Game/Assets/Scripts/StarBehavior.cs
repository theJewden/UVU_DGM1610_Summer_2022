using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBehavior : MonoBehaviour
{

    private float outOfBounds = -15;
    public float speed = 40;
    public float maxSpeed = 200f;
    public float minSpeed = 40f;
    public float size;
    public GameObject gameController;

    private void Start()
    {
        size = Random.Range(.4f, .6f);
        transform.localScale = new Vector3(size, size, size);
        gameController = GameObject.Find("GameController");
    }

    void Update()
    {
        if(gameController.GetComponent<GameController>().isPowerUpActive)
        {
            speed = maxSpeed;
        } else
        {
            speed = minSpeed;
        }

        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.z < outOfBounds)
        {
            Destroy(gameObject);
        }
    }
}
