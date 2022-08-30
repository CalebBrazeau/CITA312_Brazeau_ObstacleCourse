using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float fltTimeToWait = 3f;
    private float fltAliveTime;

    // Start is called before the first frame update
    void Start()
    {
        // Set fltAliveTime to random number in range
        fltAliveTime = Random.Range(10f, 40f);

        // Get objects Mesh Renderer
        renderer = GetComponent<MeshRenderer>();
        // Disable objects Mesh Renderer
        renderer.enabled = false;

        // Get objects Rigidbody
        rigidbody = GetComponent<Rigidbody>();
        // Disable objects Rigidbody gravity
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        // If a certain amount of time has passed
        if(Time.time > fltTimeToWait)
        {
            // Enable object mesh renderer and gravity
            renderer.enabled = true;
            rigidbody.useGravity = true;

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
}
