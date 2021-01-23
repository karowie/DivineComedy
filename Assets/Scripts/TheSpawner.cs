using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSpawner : MonoBehaviour
{
    public GameObject fallingCoinPrefab;
    //public Camera cameraStarting;
    //public Camera cameraMain;
    public GameObject character;
    public GameObject menu;
    public float secondBetweenSpawns = 0.1f;
    float nextSpawnTime;
    //Vector2 screenHalfSizeWorldUnits;
    public Vector2 spawnSizeMinMax;
    void Start()
    {
        //screenHalfSizeWorldUnits = new Vector2(cameraMain.aspect * cameraMain.orthographicSize, cameraMain.orthographicSize);
    }

    void Update()
    {
        if(Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondBetweenSpawns;
            float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);
            Vector2 spawnPosition = new Vector2(0, 0);
            if (menu.activeSelf == true)
            {
                spawnPosition = new Vector2(Random.Range(6, 36), 25);
            }
            else
            {
                
                //Vector2 spawnPosition = new Vector2(Random.Range(character.transform.position.x+10, character.transform.position.x + 50), 26f);
                //Vector2 spawnPosition = new Vector2(Random.Range(-46.3f, 84.3f), 26f);
                //Vector2 spawnPosition = new Vector2(Random.Range(-46.3f, 84.3f), character.transform.position.y + 10);
                spawnPosition = new Vector2(Random.Range(character.transform.position.x - 10, character.transform.position.x + 10), character.transform.position.y + 5);
                
            }
            GameObject newCoin = (GameObject)Instantiate(fallingCoinPrefab, spawnPosition, Quaternion.identity);
            newCoin.transform.localScale = Vector2.one * spawnSize;
        }

    }
}
