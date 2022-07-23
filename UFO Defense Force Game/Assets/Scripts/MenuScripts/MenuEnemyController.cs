using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEnemyController : MonoBehaviour
{

    public bool isHit = false;
    public int health = 100;
    public GameObject death;
    private float isHitTimer;
    private float isHitTimerMax = .10f;
    private Color isHitColor = Color.red;
    private Color isNormalColor = Color.white;


    private void Start()
    {
        isHitTimer = isHitTimerMax;
    }

    void Update()
    {
        if(isHit)
        {
            if(isHitTimer > 0)
            {
                isHitTimer -= 1 * Time.deltaTime;
                if(gameObject.GetComponent<Renderer>().material.color != isHitColor)
                {
                    gameObject.GetComponent<Renderer>().material.color = isHitColor;
                    GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().Play("Hit");
                }
            }
            else
            {
                isHit = false;
                isHitTimer = isHitTimerMax;
                gameObject.GetComponent<Renderer>().material.color = isNormalColor;
                health -= 1;
            }
        }

        if(health <= 0)
        {
            death.SetActive(true);
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioController>().Play("Explode");
            Destroy(gameObject);
        }
    }
}
