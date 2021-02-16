using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingFires : MonoBehaviour
{
    Animator myAnimator;
    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        myAnimator.SetTrigger("moveFries");
    }
}

