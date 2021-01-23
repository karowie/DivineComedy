using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmanScript : MonoBehaviour
{
    public GameObject character;
    public GameObject windman;

    void Update()
    {
        if((character.transform.position.x > windman.transform.position.x)&&(windman.gameObject.activeSelf==true))
        {
            windman.gameObject.SetActive(false);
            Destroy(windman.gameObject);
        }
    }
}
