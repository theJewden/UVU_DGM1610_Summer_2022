using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDContainer : MonoBehaviour
{
    public ID idObj;

    private void Awake()
    {
        ChangeColor(idObj.color);
    }


    public void ChangeColor (Color color)
    {
        var spriteRen = gameObject.GetComponent<SpriteRenderer>();
        spriteRen.color = color;
    }
}
