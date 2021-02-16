using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource playSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(playSound!=null)
            playSound.Play();
    }
}
