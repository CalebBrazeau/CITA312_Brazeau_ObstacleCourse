using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Variables to control rotation speed and direction
    [SerializeField] float fltXAngle = 0f;
    [SerializeField] float fltYAngle = 0f;
    [SerializeField] float fltZAngle = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate object
        transform.Rotate(fltXAngle, fltYAngle, fltZAngle);
    }
}
