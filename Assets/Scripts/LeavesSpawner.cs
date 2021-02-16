using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeavesSpawner : MonoBehaviour
{
    public GameObject fallingLeafPrefab;
    public GameObject character;
    public GameObject menu;
    public float secondBetweenSpawns = 0.5f;
    float nextSpawnTime;
    public Vector2 spawnSizeMinMax = new Vector2(1, 3);
    Vector2 spawnPosition;
    Vector3 v;
    Quaternion spawnRotation;

    private void Start()
    {
        spawnPosition = new Vector2(0, 0);
    }


    void Update()
    {
        float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);
        if (Time.time > nextSpawnTime)
        {
            if (menu.activeSelf == true)
            {
                spawnPosition = new Vector2(Random.Range(-40, 20), 80);
            }
            else
            {
                spawnPosition = new Vector2(Random.Range(character.transform.position.x - 10, character.transform.position.x + 10), character.transform.position.y + 5);
            }

            nextSpawnTime = Time.time + secondBetweenSpawns;
            //v.x = Random.Range(0, 0);
            //v.y = Random.Range(0, 0);
            //v.z = Random.Range(0.0f, 360.0f);
            //spawnRotation = Quaternion.Euler(v);
            //GameObject newLeaf = (GameObject)Instantiate(fallingLeafPrefab, spawnPosition, spawnRotation);
            GameObject newLeaf = (GameObject)Instantiate(fallingLeafPrefab, spawnPosition, Quaternion.identity);
            newLeaf.transform.localScale = Vector2.one * spawnSize;
        }

    }
}
