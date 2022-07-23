using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Player Variables
    public float horizontalInput;
    public float verticalInput;
    public float speed = 25;
    public float offScreenX = 18;
    public bool powerUped = false;
    public string powerUp = "noPower"; // "UnlimAmmo" means the unlimited ammo powerup is active

    // Object Variables
    public Transform blaster;
    public GameObject laserBolt;
    public GameObject thePowerUp;
    public GameObject powerMusic;
    public GameObject normalMusic;
    public GameObject gameController;

    //Spawn Powerup Variables
    private float powerUpTimerSeconds = 10;
    private float powerUpTimerSecondsMax = 10;
    public bool powerUpTimerSet = false;
    private float spawnPowerX;
    private float spawnPowerZ = 16.0f;
    private float spawnPowerXMax = 18.0f;
    private float powerUpSpawnRate;
    private bool powerMusicCheck = false;
    private int dieRoll;

    // Player In Damage Vars
    public bool playerInDamage = false;
    public float isHurtTime;
    private float isHurtTimeMax = 1.0f;
    private Color isHurtColor = Color.red;
    private Color isPowerUpAmmo = Color.green;
    private Color isNormalColor;
    private bool isHurtTimerSet = false;

    private void Start()
    {
        isNormalColor = gameObject.GetComponent<Renderer>().material.color;
        isHurtTime = isHurtTimeMax;
        powerUpSpawnRate = Random.Range(10, 30);
        InvokeRepeating("SpawnPowerUp",powerUpSpawnRate, powerUpSpawnRate);
        gameController = GameObject.Find("GameController");
    }


    void Update()
    {
        //Initalize to recieve values from keybindings
        horizontalInput = Input.GetAxis("Horizontal");

        spawnPowerX = Random.Range(-spawnPowerXMax, spawnPowerXMax);
        dieRoll = Random.Range(1, 7);

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


        if (playerInDamage)
        {
            if(!isHurtTimerSet)
            {
                isHurtTimerSet = true;
                gameObject.GetComponent<Renderer>().material.color = isHurtColor;
            }

            if(isHurtTime > 0)
            {
                isHurtTime -= 1 * Time.deltaTime;
            } else
            {
                playerInDamage = false;
                isHurtTime = isHurtTimeMax;
                isHurtTimerSet = false;
                gameObject.GetComponent<Renderer>().material.color = isNormalColor;
            }
        } else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                //Create Laserbolt at the blaster position
                Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
            }

            // Timer for power up duration
            if (powerUpTimerSet)
            {

                if (powerUpTimerSeconds > 0)
                {
                    powerUpTimerSeconds -= 1 * Time.deltaTime;
                    gameController.GetComponent<GameController>().isPowerUpActive = true;

                    if (gameObject.GetComponent<Renderer>().material.color != isPowerUpAmmo)
                    {
                        gameObject.GetComponent<Renderer>().material.color = isPowerUpAmmo;
                    }

                    if(!powerMusicCheck)
                    {
                        powerMusic.SetActive(true);
                        normalMusic.SetActive(false);
                        powerMusicCheck = true;

                    }

                }
                else if (powerUpTimerSeconds <= 0)
                {
                    powerUp = "noPower";
                    powerUpTimerSet = false;
                    powerUpTimerSeconds = powerUpTimerSecondsMax;
                    gameObject.GetComponent<Renderer>().material.color = isNormalColor;
                    gameController.GetComponent<GameController>().isPowerUpActive = false;
                    powerMusic.SetActive(false);
                    normalMusic.SetActive(true);
                    powerMusicCheck = false;
                    Debug.Log("Time Ended!");
                }

                // Update inbetween spawnrate of power up
                powerUpSpawnRate = Random.Range(10, 30);

            }
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
            if (dieRoll >= 5)
            {
                Instantiate(thePowerUp, new Vector3(spawnPowerX, 0, spawnPowerZ), thePowerUp.transform.rotation);
                Debug.Log("Spawn Powerup");

            } else
            {
                Debug.Log("PowerUp Missed the Die Roll :(");
            }


        } else if (powerUp != "noPower")
        {
            Debug.Log("There is already a powerup so none shall spawn");
        }
    }





}
