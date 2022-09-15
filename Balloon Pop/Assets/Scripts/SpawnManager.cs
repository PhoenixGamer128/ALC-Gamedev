using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs; // Array to store balloons
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 16.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    void SpawnRandomBalloon()
    {
        // Random position on x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange,xRange),-16,0);
        // Pick random balloon from the balloon array
        int balloonIndex = Random.Range(-balloonPrefabs.Length,balloonPrefabs.Length);
        
        // Code to make lower value balloons more common
        balloonIndex += Random.Range(-balloonPrefabs.Length,balloonPrefabs.Length);
        balloonIndex  = (balloonIndex / 2);
        if (balloonIndex < 0) balloonIndex *= -1;
        

        // Spawn random balloon at random position
        Instantiate(balloonPrefabs[balloonIndex],spawnPos,balloonPrefabs[balloonIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
