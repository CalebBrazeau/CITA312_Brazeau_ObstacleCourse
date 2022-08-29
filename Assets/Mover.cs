using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float fltMoveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("This is happening once on initialization");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is happening once per frame");
        float fltxValue = Input.GetAxis("Horizontal") * Time.deltaTime * fltMoveSpeed;
        float fltzValue = Input.GetAxis("Vertical") * Time.deltaTime * fltMoveSpeed;
        transform.Translate(fltxValue, 0f, fltzValue);        
    }
}
