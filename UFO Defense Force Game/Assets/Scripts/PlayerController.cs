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
    public bool inbetweenPowerTimer = true;
    private float inbetweenPowerSeconds = 748;
    private float inbeweenPlaceHold = 748;
    private float inbetweenPowerSecondsMin = 10;
    private float inbetweenPowerSecondsMax = 30;
    private float spawnPowerX;
    private float spawnPowerZ = 16.0f;
    private float spawnPowerXMax = 34.0f;


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
                inbetweenPowerTimer = true;
                Debug.Log("Time Ended!");
            }

        }

        //Spawn Powerup
            //Start Timer
        if (powerUp == "noPower" && inbetweenPowerTimer == true && inbetweenPowerSeconds == inbeweenPlaceHold)
        {
            inbetweenPowerSeconds = Random.Range(inbetweenPowerSecondsMin, inbetweenPowerSecondsMax);
            inbetweenPowerTimer = false;

        }

        if(inbetweenPowerSeconds > 0 && inbetweenPowerSeconds != inbeweenPlaceHold) 
        {
            inbetweenPowerSeconds -= Time.deltaTime;
            Debug.Log(inbetweenPowerSeconds);

        } else if (inbetweenPowerSeconds < 0)
        {

            //Spawn powerup in random place
            spawnPowerX = Random.Range(-spawnPowerXMax, spawnPowerXMax);
            Instantiate(thePowerUp, new Vector3(spawnPowerX, 0, spawnPowerZ), thePowerUp.transform.rotation);
            inbetweenPowerSeconds = inbeweenPlaceHold;
            Debug.Log("Spawn Powerup");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.isTrigger)
        {
            Destroy(other.gameObject);
        }

    }




}
