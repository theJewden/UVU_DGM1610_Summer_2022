using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBehavior : MonoBehaviour
{
    public float seconds = 1;
    public WaitForSeconds wfsObj;

    private void Awake()
    {
        wfsObj = new WaitForSeconds(seconds);
    }

    private IEnumerator Start()
    {
        yield return wfsObj;
        Destroy(gameObject);
    }
}
