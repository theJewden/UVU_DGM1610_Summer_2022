using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Vars
    public float horizontalInput;
    public float verticalInput;
    public float speed = 25;
    public float offScreenX = 35;
    public bool powerUped = false;
    public string powerUp = "noPower"; // "UnlimAmmo" means the unlimited ammo powerup is active

    public Transform blaster;
    public GameObject laserBolt;
    public GameObject thePowerUp;

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

        // Create Powerup if I hit enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(thePowerUp, new Vector3(0,0,0), thePowerUp.transform.rotation);
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
