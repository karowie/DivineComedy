﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingLeaf : MonoBehaviour
{
    float speed = 2;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
}
