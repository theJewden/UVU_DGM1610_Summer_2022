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
    private string laserType = "LaserOne";

    void Awake()
    {

        GameObject[] laserShot = GameObject.FindGameObjectsWithTag("Laser");
        player = GameObject.FindWithTag("Player");
        laserNumber = laserShot.Length;

        int randomChoice = Random.Range(0, 3);
        switch (randomChoice)
        {
            case 0:
                laserType = "LaserOne";
                break;
            case 1:
                laserType = "LaserTwo";
                break;
            case 2:
                laserType = "LaserThree";
                break;
        }

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
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().Play("NoAmmo");
            Destroy(gameObject);
        } else
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().Play(laserType);
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
