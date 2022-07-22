using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static int health = 3;
    private static int maxHealth = 5;
    private static int score = 0;

    public int Health = health;
    public int MaxHealth = maxHealth;
    public int Score = score;

    public void Update()
    {

        Health = health;
        MaxHealth = maxHealth;
        Score = score;

        if (Health <= 0)
        {
            // If player fully dies... pause game FOR GOOD
            Time.timeScale = 0;
        } else
        {
            Time.timeScale = 1;
        }
    }

    public void AdjustHealth(int amount)
    {
        health += amount;
    }

    public void AdjustScore (int amount)
    {
        score += amount;
    }

    public void AdjustMaxHealth(int amount)
    {
        maxHealth += amount;
    }

}
