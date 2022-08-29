using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int intHits = 0;

    private void OnCollisionEnter(Collision other) {
        intHits++;
        Debug.Log("You have bumped into something : " + intHits + " Times");
    }
}
