using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//集めたアイテムをテキストコントロラに返すスクリプト
public class itemCount : MonoBehaviour
{

    public GameObject TextController;
    textScr text;

    public bool SitemFlg = false;

    void Start()
    {

        TextController = GameObject.Find("TextController");
        text = TextController.GetComponent<textScr>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "item")
        {
            text.scoreNum += 10;  //スコアを返す
            text.scoreCount++;    //集めたアイテムの個数を返す

        }
        else if (other.tag == "Sitem")
        {
            SitemFlg = true;
        }
    }
}
