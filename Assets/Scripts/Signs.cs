using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Signs : MonoBehaviour
{
    public GameObject character;
    public GameObject first;
    public GameObject second;
    public GameObject third;
    public GameObject fourth;
    public GameObject fifth;
    public GameObject doors;
    void Start()
    {
        first.SetActive(false);
        second.SetActive(false);
        third.SetActive(false);
        fourth.SetActive(false);
        fifth.SetActive(false);
        doors.SetActive(false);
    }

    void Update()
    {
        if((first.activeSelf == false)&&(character.transform.position.y > 1.77)&&(character.transform.position.y < 1.9))
        {
            if(character.transform.position.x < -21.93207)
            {
                first.SetActive(true);
            }
            if (character.transform.position.x > -17.96982)
            {
                SceneManager.LoadScene(7);
            }
        }
        if ((second.activeSelf == false) && (character.transform.position.y > 6.95) && (character.transform.position.y > 7.1))
        {
            if (character.transform.position.x < -22.62263)
            {
                second.SetActive(true);
            }
            if (character.transform.position.x > -17.94365)
            {
                SceneManager.LoadScene(7);
            }

        }
        if ((third.activeSelf == false) && (character.transform.position.y > 12.25) && (character.transform.position.y > 12.31))
        {
            if(character.transform.position.x > -16.30461)
            {
                third.SetActive(true);
            }
            if (character.transform.position.x < -23.73532)
            {
                SceneManager.LoadScene(7);
            }
        }
        if ((fourth.activeSelf == false) && (character.transform.position.y > 17.45) && (character.transform.position.y > 17.55))
        {
            if(character.transform.position.x < -24.66812)
            {
                fourth.SetActive(true);
            }
            if (character.transform.position.x > -17.94365)
            {
                SceneManager.LoadScene(7);
            }

        }
        if ((fifth.activeSelf == false) && (character.transform.position.y > 22.58) && (character.transform.position.y > 22.61))
        {
            if(character.transform.position.x > -14.41901)
            {
                fifth.SetActive(true);
            }
            if (character.transform.position.x < -25.65916)
            {
                SceneManager.LoadScene(7);
            }

        }
        if ((doors.activeSelf == false) && (character.transform.position.y > 27.88) && (character.transform.position.y > 27.95))
        {
            if(character.transform.position.x < -25.65916)
            {
                doors.SetActive(true);
            }
            if (character.transform.position.x > -14.41901)
            {
                SceneManager.LoadScene(7);
            }

        }

    }
}
