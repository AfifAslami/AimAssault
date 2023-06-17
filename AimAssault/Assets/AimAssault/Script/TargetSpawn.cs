using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public GameObject target;
    float minSpawnPosZ = 37;
    float maxSpawnPosZ = 47;
    float spawnPosY = 4;
    float minSpawnPosX = 35;
    float maxSpawnPosX = 38;
    public float startSpawning = 2.0f; 
    public float minSpawningInterval = 1.0f;
    public float maxSpawningInterval = 1.5f;

    public int targetCounter = 0;

    
    void Start()
    {
        InvokeRepeating("SpawnRandomTarget", startSpawning, Random.Range(minSpawningInterval, maxSpawningInterval));
    }

    void Update()
    {   
    
    }

    public void SpawnRandomTarget()
    {
        if (targetCounter < 3)
        {
            Vector3 spawnPos = new Vector3((Random.Range(minSpawnPosX,maxSpawnPosX)), spawnPosY, (Random.Range(minSpawnPosZ,maxSpawnPosZ)));
            Instantiate(target, spawnPos, target.transform.rotation);
            targetCounter++;
        }
    }
}