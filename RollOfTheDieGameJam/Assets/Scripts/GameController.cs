using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController instance;
    // Private Vars
    private static float health = 3;
    private static float maxHealth = 3;
    private static float moveSpeed = 5f;
    private static float fireRate = 0.5f;
    private static float bulletSize = .35f;
    

    //Make our private vars be able to be called
    public static float Health { get => health; set { health = value; } }
    public static float MaxHealth { get => maxHealth; set { maxHealth = value; } }
    public static float MoveSpeed { get => moveSpeed; set { moveSpeed = value; } }
    public static float FireRate { get => fireRate; set { fireRate = value; } }
    public static float BulletSize { get => bulletSize; set { bulletSize = value; } }
    //public Text textHealth;

    public void Awake()
    {
       if (instance == null)
        {
            instance = this;
        }
    }


    // Update is called once per frame
    void Update()
    {
        //textHealth.text = "Health: " + health;
    }

    public static void DamagePlayer(float damage)
    {
        health -= damage;
        Debug.Log(damage + " was taken.");

        if (health <= 0)
        {
            KillPlayer();
        }
    }

    public static void HealPlayer(float heal)
    {
        if (health + heal < maxHealth)
        {
            health += heal;
        } else if (health + heal >= maxHealth)
        {
            health = maxHealth;
        }
    }

    private static void KillPlayer()
    {
        
    }

    public static void ChangeMoveSpeed(float speedChange)
    {
        moveSpeed += speedChange; 
    }

    public static void ChangeFireRate(float changeFireRate)
    {
        fireRate -= changeFireRate;
    }

    public static void ChangeBulletSize(float changeBulletSize)
    {
        bulletSize += changeBulletSize;
    }
}
