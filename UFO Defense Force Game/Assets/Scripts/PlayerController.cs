using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Player Variables
    public float horizontalInput;
    public float verticalInput;
    public float speed = 25;
    public float offScreenX = 35;
    public bool powerUped = false;
    public string powerUp = "noPower"; // "UnlimAmmo" means the unlimited ammo powerup is active

    // Object Variables
    public Transform blaster;
    public GameObject laserBolt;
    public GameObject thePowerUp;

    //Spawn Powerup Variables
    private float powerUpTimerSeconds = 10;
    private float powerUpTimerSecondsMax = 10;
    public bool powerUpTimerSet = false;
    private float spawnPowerX;
    private float spawnPowerZ = 16.0f;
    private float spawnPowerXMax = 34.0f;
    private float powerUpSpawnRate;

    private void Start()
    {
        powerUpSpawnRate = Random.Range(10, 30);
        InvokeRepeating("SpawnPowerUp",powerUpSpawnRate, powerUpSpawnRate);
    }


    void Update()
    {
        //Initalize to recieve values from keybindings
        horizontalInput = Input.GetAxis("Horizontal");


        //Move the Player
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Keep player within bounds
        if (transform.position.x < -offScreenX)
        {
            transform.position = new Vector3(-offScreenX, transform.position.y, transform.position.z);

        } 
        
        if (transform.position.x > offScreenX)
        {
            transform.position = new Vector3(offScreenX, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Create Laserbolt at the blaster position
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }

        // Timer for power up duration
        if (powerUpTimerSet == true)
        {
            
            if (powerUpTimerSeconds > 0)
            {
                powerUpTimerSeconds -= 1 * Time.deltaTime;
                Debug.Log(powerUpTimerSeconds);

            } else if(powerUpTimerSeconds <= 0)
            {
                powerUp = "noPower";
                powerUpTimerSet = false;
                powerUpTimerSeconds = powerUpTimerSecondsMax;
                Debug.Log("Time Ended!");
            }

            // Update inbetween spawnrate of power up
            powerUpSpawnRate = Random.Range(10, 30);

        }



    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.isTrigger)
        {
            Destroy(other.gameObject);
        }

    }

    private void SpawnPowerUp()
    {
        //Spawn Powerup
        if (powerUp == "noPower")
        {

            //Spawn powerup in random place
            spawnPowerX = Random.Range(-spawnPowerXMax, spawnPowerXMax);
            Instantiate(thePowerUp, new Vector3(spawnPowerX, 0, spawnPowerZ), thePowerUp.transform.rotation);
            Debug.Log("Spawn Powerup");

        } else if (powerUp != "noPower")
        {
            Debug.Log("There is already a powerup so none shall spawn");
        }
    }




}
