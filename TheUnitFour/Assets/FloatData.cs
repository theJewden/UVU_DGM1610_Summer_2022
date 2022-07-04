using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public GameObject Player;
    public bool moveActive;

    public float value;

    public void SetValue(float num)
    {
        value = num;
    }

    public void UpdateValue(float num)
    {
        value += num;
    }

    public void MovePlayerInDir(float moveSpeed)
    {
        if (moveActive == true)
        {
            Player = GameObject.Find("Player");
            Player.transform.position = new Vector2(Player.transform.position.x + moveSpeed * Time.deltaTime, Player.transform.position.y);
        }


    }

    public void TriggerTrue(bool trigger)
    {
        moveActive = trigger;
    }


}
