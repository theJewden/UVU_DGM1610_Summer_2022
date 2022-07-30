using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;

    private void Awake()
    {
        idObj = GetComponent<IDContainer>().idObj;
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherID = idObj; //Temp Var

        if (other.GetComponent<IDContainer>() != null) // Check if object has IDContainer script
        {
            otherID = other.GetComponent<IDContainer>().idObj; // Get ID from component if it has a script
        } else
        {
           otherID = null; // If the object doesn't have the script make it null and give us an error message
           Debug.Log("The object that has collided with " + idObj + " does not have the IDContainer script.");
        }
        

        if (otherID != null) // Check to make sure it has an ID
        {
            if (otherID == idObj)
            {
                matchEvent.Invoke(); // If they have the same ID they match
            } else
            {
                noMatchEvent.Invoke(); // If they do not have the same ID they did not match
            }
        } else
        {
            Debug.Log("The object that has collided with " + idObj + " doesn't have an ID");
            return; //If the object doesn't have an ID return
        }

    }
}
