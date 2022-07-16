using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardShip : MonoBehaviour
{

    private float outOfBounds = -15;
    public float speed = 10;

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.z < outOfBounds)
        {
            Destroy(gameObject);
        }
    }
}
