using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    //public GameObject heartsObject;
    public Text count;
    public int numberOfDiffrentHearts;
    private int lastnumberOfAllHearts;
    void Start()
    {
        lastnumberOfAllHearts = GameObject.Find("Hearts").transform.childCount;
        int numberOfHeartsInOneColor = lastnumberOfAllHearts / numberOfDiffrentHearts;
        count.text = numberOfHeartsInOneColor.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        var hearts = GameObject.Find("Hearts");
        if (lastnumberOfAllHearts != hearts.transform.childCount)
        {
            lastnumberOfAllHearts--;
            count.text = (int.Parse(count.text)-1).ToString();
        }
    }
}
