using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUIController : MonoBehaviour
{

    private float health;
    private float numOfHearts;
    private bool numHalf = false;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;

    public void Update()
    {
        health = GameController.Health;
        numOfHearts = (GameController.MaxHealth);
        
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for(float i = 0; i < hearts.Length; i++)
        {
            if(numHalf == false)
            {
                //Check to see if health will equal half health next rotation of forLoop
                if (i + 1.5 == health)
                {
                    numHalf = true;
                }

                if (i == 0 && health == .5f)
                {
                    hearts[(int)i].sprite = halfHeart;
                } else if (i < health)                 // Make heart either full or not full
                {
                    hearts[(int)i].sprite = fullHeart;
                } else
                {
                    hearts[(int)i].sprite = emptyHeart;
                }

            } else
            {
                // If it is supposed to be a half heart -- Make it a half heart
                hearts[(int)i].sprite = halfHeart;
                numHalf = false;

            }


            if(i < numOfHearts)
            {
                hearts[(int)i].enabled = true;
            } else if (i >= numOfHearts)
            {
                hearts[(int)i].enabled = false;
            }
        }
        
    }


} //hearts[i].sprite = halfHeart;
