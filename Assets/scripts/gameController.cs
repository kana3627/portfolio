using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class gameController : MonoBehaviour
{

    public GameObject plyr;
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject textCntr;

    itemCount item;
    textScr text;

    void Start()
    {
        plyr = GameObject.Find("player");
        enemy = GameObject.Find("RedEnemy");
        enemy1 = GameObject.Find("PinkEnemy");
        textCntr = GameObject.Find("TextController");

        item = plyr.GetComponent<itemCount>();
        text = textCntr.GetComponent<textScr>();
    }


    void Update()
    {
        //ゲームが終了したら、敵の動きを止める
        if (text.textFlg == true)
        {
            enemy.GetComponent<NavMeshAgent>().isStopped = true;
            enemy1.GetComponent<NavMeshAgent>().isStopped = true;
        }

        //スタンアイテムを取得したら、敵の挙動を変更する
        if (item.SitemFlg == true)
        {
            enemy.GetComponent<Renderer>().material.color = new Color(180, 0, 255, 255);
            enemy1.GetComponent<Renderer>().material.color = new Color(180, 0, 255, 255);

            enemy.GetComponent<NavMeshAgent>().speed = 1f;
            enemy1.GetComponent<NavMeshAgent>().speed = 1f;
            Invoke("Reset", 3.0f);
        }

    }

    private void Reset()
    {
        enemy.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 255);
        enemy1.GetComponent<Renderer>().material.color = new Color(255, 148, 255, 255);

        enemy.GetComponent<NavMeshAgent>().speed = 3.5f;
        enemy1.GetComponent<NavMeshAgent>().speed = 3.5f;
        item.SitemFlg = false;

    }
}