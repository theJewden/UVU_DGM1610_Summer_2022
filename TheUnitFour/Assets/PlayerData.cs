using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Player Info")]

public class PlayerData : ScriptableObject
{
    //Establish the Vars
    public string playerName;
    public float playerHealth;
    public float playerHealthMax;
    public int playerLevel;
    public int playerLevelMax;


    private void UpdatePlayerName(string nam)
    {
        playerName = nam;
    }

    private void EstablishMaxHealth(float num)
    {
        playerHealthMax = num;
    }

    private void UpdateHealth(float num)
    {
        if ((playerHealth+num) < playerHealthMax && (playerHealth+num) > 0)
        {
            playerHealth += num;

        } else if ((playerHealth+num) > playerHealthMax)
        {
            playerHealth = playerHealthMax;
        } else if ((playerHealth+num) < 0)
        {
            playerHealth = 0;
        } else
        {
            Debug.Log("An Error has Occured.");
        }
    }

    public void EstablishMaxLevel(int num)
    {
        playerLevelMax = num;
    }

    private void UpdateLevel(int num)
    {
        if ((playerLevel + num) < playerLevelMax)
        {
            playerLevel += num;

        }
        else if ((playerLevel + num) > playerLevelMax)
        {
            playerLevel = playerLevelMax;
        }
        else
        {
            Debug.Log("An Error has Occured.");
        }
    }

}
