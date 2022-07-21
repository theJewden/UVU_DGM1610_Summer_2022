using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    // Game Objects (The different doors of the room) -- Setup within Unity's Inspector
    public GameObject rightDoor;
    public GameObject leftDoor;
    public GameObject bottomDoor;
    public GameObject topDoor;
    public GameObject rightWall;
    public GameObject leftWall;
    public GameObject bottomWall;

    // Keep track of if we want a door there or not
    public bool rightDoorExists = false;
    public bool leftDoorExists = false;
    public bool bottomDoorExists = false;
    public bool topDoorExists = false;

    public void Awake ()
    {
        if (rightDoorExists)
        {
            rightDoor.SetActive(true);
            rightWall.SetActive(false);
        } else
        {
            rightDoor.SetActive(false);
            rightWall.SetActive(true);
        }

        if (leftDoorExists)
        {
            leftDoor.SetActive(true);
            leftWall.SetActive(false);
        } else
        {
            leftDoor.SetActive(false);
            leftWall.SetActive(true);
        }

        if (bottomDoorExists)
        {
            bottomDoor.SetActive(true);
            bottomWall.SetActive(false);
        } else
        {
            bottomDoor.SetActive(false);
            bottomWall.SetActive(true);
        }

        if(topDoorExists)
        {
            topDoor.SetActive(true);
        }
    }

}
