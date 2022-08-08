using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Int Data: Not Highscore")]

public class IntData2 : ScriptableObject
{
    public int value = 0;

    public void UpdateValue(int num)
    {
        
        if ((value+num) > 0)
        {
            value += num;
        } else
        {
            value = 0;
        }
        
    }

    public void ChangeValue(int num)
    {
        if (num >= 0)
        {

            value = num;
        }

    }



}
