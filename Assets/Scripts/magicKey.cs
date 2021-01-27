using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class magicKey : MonoBehaviour
{
    public GameObject character;
    public GameObject dog1;
    public GameObject dog2;
    public GameObject dog3;
    public GameObject dog4;
    public Renderer rend;
    public Text dialog;
    private Transform chtp;
    //public GameObject key;
    void Start()
    {
        chtp = character.transform;
        rend.material.color = Color.grey;
    }
    void Update()
    {
        this.transform.position = new Vector3(chtp.position.x, chtp.position.y + 1.33f, chtp.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("magicKey"))
        {
            if(collision.name.EndsWith("_red"))
                rend.material.color = Color.red;
            else if (collision.name.EndsWith("_green"))
                rend.material.color = Color.green;
            else if (collision.name.EndsWith("_blue"))
                rend.material.color = Color.blue;
            else if (collision.name.EndsWith("_yellow"))
                rend.material.color = Color.yellow;
        }
        if (collision.CompareTag("magicWall"))
        {
            if(collision.name.EndsWith("_red")&&(rend.material.color == Color.red))
            {
                rend.material.color = Color.grey;
                collision.gameObject.SetActive(false);
                Destroy(collision.gameObject);
                StartCoroutine(dogText(dog1));

            }
            else if (collision.name.EndsWith("_blue") && (rend.material.color == Color.blue))
            {
                rend.material.color = Color.grey;
                collision.gameObject.SetActive(false);
                Destroy(collision.gameObject);
                StartCoroutine(dogText(dog2));

            }
            else if (collision.name.EndsWith("_green") && (rend.material.color == Color.green))
            {
                rend.material.color = Color.grey;
                collision.gameObject.SetActive(false);
                Destroy(collision.gameObject);
                StartCoroutine(dogText(dog3));

            }
            else if (collision.name.EndsWith("_yellow") && (rend.material.color == Color.yellow))
            {
                rend.material.color = Color.grey;
                collision.gameObject.SetActive(false);
                Destroy(collision.gameObject);
                StartCoroutine(dogText(dog4));

            }
        }
    }

    IEnumerator dogText(GameObject dog)
    {
        dialog.text = "I am free!\nThank you!";
        yield return new WaitForSecondsRealtime(2);
        dialog.text = "";
        dog.gameObject.SetActive(false);
        Destroy(dog.gameObject);
    }






}
