using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Variable to store the number of hits
    private int intHits = 0;

    private void OnCollisionEnter(Collision other) {
        // If the collided object does not have the "Hit" tag
        if(other.gameObject.tag != "Hit")
        {
            // Increment the number of hits variable
            intHits++;
            // Log the number of hits
            Debug.Log("You have bumped into something : " + intHits + " Times");
        }
    }
}
