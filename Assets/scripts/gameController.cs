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

    playerMoveScr playerSpeed;
    playerScr player;
    itemCount item;
    textScr text;
    Color alpha = new Color(0, 0, 0, 0.1f);
    void Start()
    {
        plyr = GameObject.Find("player");
        enemy = GameObject.Find("RedEnemy");
        enemy1 = GameObject.Find("PinkEnemy");
        textCntr = GameObject.Find("TextController");

        player = plyr.GetComponent<playerScr>();
        playerSpeed = plyr.GetComponent<playerMoveScr>();
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
            player.flg = false;

            enemy.GetComponent<Renderer>().material.color = new Color(180, 0, 255, 255);
            enemy1.GetComponent<Renderer>().material.color = new Color(180, 0, 255, 255);

            enemy.GetComponent<NavMeshAgent>().speed = 1f;
            enemy1.GetComponent<NavMeshAgent>().speed = 1f;
            Invoke("Reset", 3.0f);


        }

        //playerが通常状態の敵に捕まった時の挙動
        if (player.flg == true)
        {
            behavior();
        }

    }

    //深い意味はない
    void behavior()
    {
        playerSpeed.speed = 0f;

        enemy.GetComponent<NavMeshAgent>().isStopped = true;
        enemy1.GetComponent<NavMeshAgent>().isStopped = true;

        enemy.transform.position = new Vector3(10f, 0.5f, -7.5f);
        enemy1.transform.position = new Vector3(9f, 0.5f, -7.5f);
        //readyの文字が表示されるスクリプト（３秒後に消える）
        text.Ready.enabled = true;
        Invoke("readyDisplay", 3.0f);
        Invoke("rePlay", 3.0f);
        player.flg = false;
    }

    //スタン状態から元に戻す関数
    private void Reset()
    {

        enemy.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 255);
        enemy1.GetComponent<Renderer>().material.color = new Color(255, 148, 255, 255);

        enemy.GetComponent<NavMeshAgent>().speed = 3.5f;
        enemy1.GetComponent<NavMeshAgent>().speed = 3.5f;
        item.SitemFlg = false;

    }


    void rePlay()
    {
        //挙動を戻すスクリプト
        playerSpeed.speed = 0.1f;

        enemy.GetComponent<NavMeshAgent>().isStopped = false;
        enemy1.GetComponent<NavMeshAgent>().isStopped = false;

    }

    void readyDisplay()
    {
        text.Ready.enabled = false;
    }

}