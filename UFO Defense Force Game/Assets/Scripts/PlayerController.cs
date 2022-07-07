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


    void Start()
    {


        
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
    }
}
