using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{

    public GameObject gameController;
    public int scoreAmount;


    public void Awake()
    {
        gameController = GameObject.Find("GameController");
    }

    private void OnTriggerEnter(Collider other)
    {

       if(other.tag != "Player" && other.tag != "PowerUp" && other.tag != "Enemy")
       {
            Destroy(other.gameObject);
            Destroy(gameObject);
            gameController.GetComponent<GameController>().AdjustScore(scoreAmount);
        }

        if(other.tag == "Player")
        {
            if (other.gameObject.GetComponent<PlayerController>().playerInDamage == false)
            {
                Destroy(gameObject);
                gameController.GetComponent<GameController>().AdjustHealth(-1);
                other.gameObject.GetComponent<PlayerController>().playerInDamage = true;
            } 

        }

        


    }
}
