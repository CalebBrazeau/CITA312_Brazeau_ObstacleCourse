using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float fltTimeToWait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time elapsed since game started: " + Time.time);
        if(Time.time > fltTimeToWait)
        {
            Debug.Log("Do something");
        }
    }
}
