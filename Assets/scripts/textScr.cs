using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//UIを管理するスクリプト
public class textScr : MonoBehaviour
{
    public Text score;
    public Text Ready;
    public Text gameclear;

    public Image zanki0;
    public Image zanki1;
    public Image zanki2;
    public Image zanki3;

    public int scoreNum;
    public int scoreCount;

    GameObject[] itemObject;
    int itemNum;

    void Start()
    {
        gameclear.enabled = false;

        //itemタグがついてるオブジェクトの数をカウント
        itemObject = GameObject.FindGameObjectsWithTag("item");
        itemNum = itemObject.Length;

    }


    void Update()
    {
        score.text = "SCORE:" + scoreNum;  //itemCountで渡された
        Invoke("readyDisplay", 3.0f);

        if (scoreCount >= itemNum)
        {
            gameclear.enabled = true;
        }
    }

    void readyDisplay()
    {

        Ready.enabled = false;
    }

}
