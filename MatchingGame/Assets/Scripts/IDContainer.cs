using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDContainer : MonoBehaviour
{
    public ID idObj;
    public bool isRandom = true;
    public int currentColor;


    public void ChangeColor (Color color)
    {
        var spriteRen = gameObject.GetComponent<SpriteRenderer>();
        spriteRen.color = color;
    }

    public void ChangeColorWithGameObject(GameObject otherObj)
    {
        idObj = otherObj.GetComponent<IDContainer>().idObj;
        ChangeColor(idObj.color);
    }

    public void SetCurrentColor(IntData2 num)
    {
        currentColor = num.value;
    }

    public void SetGlobalNum (IntData2 num)
    {
        num.value = currentColor;
    }

    public void ChangeColorID(ID obj)
    {
        ChangeColor(obj.color);
        idObj = obj;
    }

    public void ChangeColorIDWithList(ColorList obj)
    {
        if(isRandom) { currentColor = Random.Range(0, obj.colorIDList.Count); }
        ChangeColor(obj.colorIDList[currentColor].color);
        idObj = obj.colorIDList[currentColor];
    }

}
