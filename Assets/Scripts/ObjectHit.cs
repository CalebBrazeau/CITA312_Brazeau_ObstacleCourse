using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // If the collided object has the "Player" tag
        if(other.gameObject.tag == "Player")
        {
            // Change objects Mesh Renderer to specified color
            GetComponent<MeshRenderer>().material.color = Color.magenta;
            // Change objects tag to "Hit"
            gameObject.tag = "Hit";
        }
    }
}
