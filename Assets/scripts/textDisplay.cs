using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textDisplay : MonoBehaviour
{
    public Text readyText;


    void Start()
    {

        StartCoroutine("text");
    }


    void Update()
    {

    }
    IEnumerable text()
    {

        readyText.enabled = false;

        yield return new WaitForSeconds(3.0f);


    }
}
