using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject dropper;

    private float fltTimeToNextSpawn;

    public float fltSpawnAreaXMin = 0f;
    public float fltSpawnAreaXMax = 0f;
    public float fltSpawnAreaZMin = 0f;
    public float fltSpawnAreaZMax = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Set next spawn time to a random number in range
        fltTimeToNextSpawn = Random.Range(5f, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        // Decrement time to next spawn
        fltTimeToNextSpawn -= Time.deltaTime;
        
        // If time to next spawn is less than or equal to zero
        if(fltTimeToNextSpawn <= 0)
        {
            // Reset time to next spawn to random number in range
            fltTimeToNextSpawn = Random.Range(5f, 15f);

            // Instantiate new dropper object in specified area
            Instantiate(dropper, new Vector3(Random.Range(fltSpawnAreaXMin, fltSpawnAreaXMax), 18, Random.Range(fltSpawnAreaZMin, fltSpawnAreaZMax)), Quaternion.identity);
        }
    }
}
