using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheThing : MonoBehaviour
{
    // Used in generating circles with objects
    public GameObject cubeObstacle;
    public int numberOfObjects = 30;
    public float radius = 22f;

    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 86, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(cubeObstacle, pos, rot);
        }
    }
}
