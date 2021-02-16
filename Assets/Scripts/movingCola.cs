using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingCola : MonoBehaviour
{
    Animator myAnimator;
    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        myAnimator.SetTrigger("moveCola");
    }
}
