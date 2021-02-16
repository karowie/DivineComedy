using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnemySpawner : MonoBehaviour
{
    public GameObject endingCanvas;
    public GameObject EnemyPrefab;
    public GameObject character;
    public float secondBetweenSpawns = 10f;
    public float gameTime = 120f;
    float nextSpawnTime;
    Vector2 spawnPosition = new Vector2(0, 0);
    int enemyCounter;
    int currentNumber;
    GameObject parentObj;
    void Start()
    {
        enemyCounter = 0;
        parentObj = GameObject.Find("Enemies");
        gameTime += Time.time;
    }

    void Update()
    { 
        
        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondBetweenSpawns;
            spawnPosition = new Vector2(Random.Range(-47f, 84f), Random.Range(-8f, 23f));
            GameObject newEnemy = (GameObject)Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
            newEnemy.transform.parent = parentObj.transform;
            enemyCounter++;
        }

        currentNumber = parentObj.transform.childCount;

        //if ((enemyCounter-currentNumber>1) && (Time.time>gameTime))
        //if(Time.time > gameTime)
        if ((enemyCounter - currentNumber > 5) && (Time.time > gameTime))
        {
            endingCanvas.SetActive(true);
            character.SetActive(false);
            Cursor.visible = true;
            //SceneManager.LoadScene(9);
        }

    }
}
