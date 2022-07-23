using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{

    public float explosionTime = 1.0f;



    void Update()
    {
        
        if (explosionTime > 0.0f)
        {
            explosionTime -= 1 * Time.deltaTime;
        } else
        {
            Destroy(gameObject);
        }

    }
}
