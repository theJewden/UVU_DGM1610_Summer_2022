using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UlimAmmoPowerUpBehavior : MonoBehaviour
{
    public float rotSpeed = 225.0f;
    public float speed = 5.0f;
    public float outOfBounds = -15.0f;
    private int powerUpNum;
    private bool createPowerUp = true;
    private int numPlayer;
    private GameObject player;


    private void Awake()
    {
        //Searches for the amount of powerups currently in game
        powerUpNum = GameObject.FindGameObjectsWithTag("PowerUp").Length;

        //Find the player object
        player = GameObject.FindWithTag("Player");

        // Find Number of player (Prevent bugs)
        numPlayer = GameObject.FindGameObjectsWithTag("Player").Length;


        //If there is a powerup in game, do not create another
        if (powerUpNum > 1)
        {
            createPowerUp = false;
            Debug.Log("There are too many power ups.");
        }

        //Make sure the player exists (Prevents bugs)
        if (numPlayer <= 0)
        {
            // If the player has a power up do not create a new one
            if (player.GetComponent<PlayerController>().powerUped == true)
            {
                createPowerUp = false;
                Debug.Log("Player currently has power up.");
            }
        }

    }
    void Start()
    {
        // If it tries to create a powerup while one exists (Destroy powerup)
        if (createPowerUp == false)
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotSpeed);
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        if (transform.position.z < outOfBounds)
        {
            Destroy(gameObject);
            player.GetComponent<PlayerController>().inbetweenPowerTimer = true;
        }

    }

    private void OnTriggerEnter(Collider player)
    {
        player.GetComponent<PlayerController>().powerUp = "UlimAmmo";
        player.GetComponent<PlayerController>().powerUpTimerSet = true;

    }
}
