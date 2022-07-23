using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMoveForwardLaser : MonoBehaviour
{

    public float speed = 50.0f;
    public float outOfBounds = 16;
    public float timerAmount = 0.5f;
    private bool isTimerSet = true;
    private string laserType = "LaserOne";

    private void Awake()
    {
        int randomChoice = Random.Range(0, 3);
        switch(randomChoice)
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

        GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().Play(laserType);
    }

    // Update is called once per frame
    void Update()
    {

        if (isTimerSet)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            if (timerAmount > 0)
            {
                timerAmount -= 1*Time.deltaTime;
            } else
            {
                isTimerSet = false;
            }
        } else
        {
            Destroy(gameObject);
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            if(other.GetComponent<MenuEnemyController>().isHit == false)
            {
                other.gameObject.GetComponent<MenuEnemyController>().isHit = true;
            }
            Destroy(gameObject);
        }
    }
}

