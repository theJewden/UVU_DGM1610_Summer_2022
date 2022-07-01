using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ObjectPosition", menuName = "Stored Position")]

public class Vector3Data : ScriptableObject
{

    public float myX;
    public float myY;
    public float myZ;

    public void UpdatedValue(float num, float num2, float num3)
    {
        myX += num;
        myY += num2;
        myZ += num3;

    }
    public void ReplacedValue(float num, float num2, float num3)
    {
        myX = num;
        myY = num2;
        myZ = num3;

    }


}
