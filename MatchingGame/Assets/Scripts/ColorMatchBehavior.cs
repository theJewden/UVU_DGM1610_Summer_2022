using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehavior : MatchBehavior
{
    public ColorList colorList;
    private int currentColor;

    public void Start()
    {
        currentColor = GetComponent<IDContainer>().currentColor;
        idObj = colorList.colorIDList[currentColor];
    }

    public void ChangeColor(SpriteRenderer ren)
    {
        var newColor = idObj as ID;
        ren.color = newColor.color;
    }
}
