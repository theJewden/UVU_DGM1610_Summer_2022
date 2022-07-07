using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardLaser : MonoBehaviour
{

    public float speed = 50.0f;
    public int laserNumber;
    public int totalLaserNumber = 1;
    public float outOfBounds = 16;
    public GameObject player;

    void Awake()
    {

        GameObject[] laserShot = GameObject.FindGameObjectsWithTag("Laser");
        player = GameObject.FindWithTag("Player");
        laserNumber = laserShot.Length;

    }

    private void Start()
    {
        //If the player doesn't have the unlim power up only shoot one bullet at a time
        if (player.GetComponent<PlayerController>().powerUp == "UlimAmmo")
        {
            totalLaserNumber = 10;
        } else
        {
            totalLaserNumber = 1;
        }


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
