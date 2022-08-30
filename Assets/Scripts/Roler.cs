using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roler : MonoBehaviour
{
    private float fltAliveTime;

    // Start is called before the first frame update
    void Start()
    {
        // Set fltAliveTime to random number in range
        fltAliveTime = Random.Range(10f, 40f);
    }

    // Update is called once per frame
    void Update()
    {
        // Decrement fltAliveTime
        fltAliveTime -= Time.deltaTime;

        // If fltAliveTime is less than or equal to zero
        if(fltAliveTime <= 0)
        {
            // Destroy the game object
            Destroy(gameObject);
        }
    }
}
