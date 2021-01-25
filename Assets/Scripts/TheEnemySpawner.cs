using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject character;
    public float secondBetweenSpawns = 10f;
    float nextSpawnTime;
    Vector2 spawnPosition = new Vector2(0, 0);
    void Start()
    {
        //screenHalfSizeWorldUnits = new Vector2(cameraMain.aspect * cameraMain.orthographicSize, cameraMain.orthographicSize);
    }

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondBetweenSpawns;
            spawnPosition = new Vector2(Random.Range(-47f, 84f), Random.Range(-8f, 23f));
            GameObject newEnemy = (GameObject)Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
        }

    }
}
