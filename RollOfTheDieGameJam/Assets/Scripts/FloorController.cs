using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
   
    public Sprite floorOne;
    public Sprite floorTwo;
    public Sprite floorThree;
    public Sprite floorFour;
    public Sprite floorFive;
    public Sprite floorSix;
    private SpriteRenderer spriteRenderer;
    private int probs;
    private int probsMax = 8;
    private int dieRoll;

    private void Awake()
    {
        probs = Random.Range(0, probsMax);
        dieRoll = Random.Range(1, 6);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        if (probs <= probsMax-2)
        {
            spriteRenderer.sprite = floorOne;

        } else
        {
            if (dieRoll == 1)
            {
                spriteRenderer.sprite = floorTwo;
            }
            else if (dieRoll == 2)
            {
                spriteRenderer.sprite = floorThree;
            }
            else if (dieRoll == 3)
            {
                spriteRenderer.sprite = floorFour;
            }
            else if (dieRoll == 4)
            {
                spriteRenderer.sprite = floorFive;
            }
            else if (dieRoll == 5)
            {
                spriteRenderer.sprite = floorSix;
            }
            else
            {
                spriteRenderer.sprite = floorOne;
            }
        }
                   
    }

               
}


