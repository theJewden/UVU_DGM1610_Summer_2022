using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IDContainer
{
    public ColorList colorList;

    private void Awake()
    {
        idObj = colorList.colorIDList[currentColor];
    }
}
