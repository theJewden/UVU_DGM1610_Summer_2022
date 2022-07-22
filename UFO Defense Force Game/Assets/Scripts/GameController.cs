using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    private static int health = 3;
    private static int maxHealth = 3;
    private static int score = 0;

    public int Health = health;
    public int MaxHealth = maxHealth;
    public int Score = score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    private void Awake()
    {
        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + health + "/" + maxHealth;
    }

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

        if (health > maxHealth)
        {
            health = maxHealth;
        }

    }

    public void AdjustHealth(int amount) // Adjust the health
    {
        health += amount;
        UpdateText();
    }

    public void AdjustScore (int amount) // Adjust the Score
    {
        score += amount;
        UpdateText();
    }

    public void AdjustMaxHealth(int amount) // Adjusts the max health
    {
        maxHealth += amount;
        UpdateText();
    }


    public void UpdateText() // Update all text
    {
        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + health + "/"+ maxHealth;
    }
}
