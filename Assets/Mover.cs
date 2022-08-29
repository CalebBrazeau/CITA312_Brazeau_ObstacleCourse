using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float fltMoveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();    
    }

    void PrintInstructions()
    {
        Debug.Log("Gaem");
        Debug.Log("Movement: WASD");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
    {
        float fltxValue = Input.GetAxis("Horizontal") * Time.deltaTime * fltMoveSpeed;
        float fltzValue = Input.GetAxis("Vertical") * Time.deltaTime * fltMoveSpeed;
        transform.Translate(fltxValue, 0f, fltzValue);        
    }
}
