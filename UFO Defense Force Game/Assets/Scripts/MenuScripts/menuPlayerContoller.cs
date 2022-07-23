using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPlayerContoller : MonoBehaviour
{
    public GameObject blaster;
    public GameObject laserBolt;


    void Start()
    {
        blaster = GameObject.Find("Shooter");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            //Create Laserbolt at the blaster position
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }
    }
}
