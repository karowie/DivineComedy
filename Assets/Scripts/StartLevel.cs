using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public GameObject startingCam;
    public GameObject mainCam;
    public GameObject startCanvas;

    AudioListener startingCamLis;
    AudioListener mainCamLis;

    public void Start()
    {
        startCanvas.SetActive(true); 
        Cursor.visible = true;
    }
    public void PlayLevel()
    {
        startingCamLis = startingCam.GetComponent<AudioListener>();
        mainCamLis = mainCam.GetComponent<AudioListener>();

        startingCam.SetActive(false);
        startingCamLis.enabled = false;

        mainCamLis.enabled = true;
        mainCam.SetActive(true);

        startCanvas.SetActive(false);

        Cursor.visible = false;
    }

}
