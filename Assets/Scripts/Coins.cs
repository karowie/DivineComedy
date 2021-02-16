using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static Coins instance;
    public CoinsItems[] itemsToPool;
    private List<GameObject> pooledObjects;
    //public AudioSource playSound;

    void Awake()
    {

        if (instance == null) instance = this;
        pooledObjects = new List<GameObject>();

        foreach (CoinsItems item in itemsToPool)
        {
            for(int i=0; i< item.coinsAmount; i++)
            {
                GameObject obj = Instantiate(item.coinObject);
                obj.name = item.name;
                obj.transform.parent = this.transform;
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }
    }
    
    public GameObject GetPooledObject(string name)
    {
        for(int i=0; i<pooledObjects.Count; i++)
        {
            if(pooledObjects[i].activeInHierarchy == false && pooledObjects[i].name == name)
            {
                return pooledObjects[i];
            }
        }

        foreach (CoinsItems item in itemsToPool)
        {
            if(item.coinObject.name == name)
            {
                GameObject obj = Instantiate(item.coinObject);
                obj.name = item.name;
                obj.transform.parent = this.transform;
                obj.SetActive(false);
                pooledObjects.Add(obj);
                return obj;
            }
        }

        return null;
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    playSound.Play();
    //}
}



[System.Serializable]
public class CoinsItems
{
    public string name;
    public int coinsAmount;
    public GameObject coinObject;
    public bool shouldExpland;
}
