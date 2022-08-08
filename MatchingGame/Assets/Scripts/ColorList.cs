using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ColorList : ScriptableObject
{
    public List<ID> colorIDList;

    public ID currentColor;

    private int num;

    public void SetCurrentColorRandomly()
    {
        num = colorIDList.Count;
        currentColor = colorIDList[num];
    }

}
