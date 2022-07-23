using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{

    public GameObject gameController;
    public GameObject explosion;
    private int chooseExplosionSound;
    private string explosionName;
    public int scoreAmount;


    public void Awake()
    {
        gameController = GameObject.Find("GameController");
        chooseExplosionSound = Random.Range(0, 3);

        switch (chooseExplosionSound)
        {
            case 0:
                explosionName = "Explode";
                break;
            case 1:
                explosionName = "ExplodeTwo";
                break;
            case 2:
                explosionName = "ExplodeThree";
                break;
            default:
                explosionName = "Explode";
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

       if(other.tag == "Laser")
       {
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().Play(explosionName);
            gameController.GetComponent<GameController>().AdjustScore(scoreAmount);
            Instantiate(explosion, gameObject.transform.position, explosion.transform.rotation);
        }

        if(other.tag == "Player")
        {
            if (other.gameObject.GetComponent<PlayerController>().playerInDamage == false)
            {
                Destroy(gameObject);
                gameController.GetComponent<GameController>().AdjustHealth(-1);
                other.gameObject.GetComponent<PlayerController>().playerInDamage = true;
                GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().Play("Hit");
            } 

        }

        


    }
}
