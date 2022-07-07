using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardLaser : MonoBehaviour
{

    public float speed = 50.0f;
    public int laserNumber;
    public int totalLaserNumber = 1;
    public float outOfBounds = 16;

    void Awake()
    {

        GameObject[] laserShot = GameObject.FindGameObjectsWithTag("Laser");
        laserNumber = laserShot.Length;

    }

    private void Start()
    {
        if (laserNumber > totalLaserNumber)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (laserNumber <= totalLaserNumber)
        {

            transform.Translate(Vector3.up * Time.deltaTime * speed);

            if (transform.position.z > outOfBounds)
            {
                Destroy(gameObject);
            }

        }


        

    }
}
