using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScr : MonoBehaviour
{

    //public float speed = 0.1f;   //移動スピード

    GameObject[] zanki;          //残機を保持する配列

    public int zankiCount = 0;          //消えるオブジェクトの要素


    public bool flg = false;

    itemCount item;

    void Start()
    {
        item = GetComponent<itemCount>();

        zanki = new GameObject[4];
        for (int i = 0; i < 4; i++)
        {
            zanki[i] = GameObject.Find("Zanki" + (i));
        }
    }


    void Update()
    {

        //残機がなくなったらgameover画面に遷移する
        if (zankiCount >= 4)
        {
            SceneManager.LoadScene("gameOver");
        }
    }



    //プレイヤが敵に当たった時の処理
    private void OnTriggerEnter(Collider other)
    {
        //敵に当たったら残機の表示を減らす処理
        if (item.SitemFlg == false && other.tag == "redEnemy" || other.tag == "pinkEnemy")
        {
            flg = true;
            zanki[zankiCount].SetActive(false);
            zankiCount++;

        }

    }

    //void moveKey()
    //{
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        transform.position += transform.forward * speed;
    //    }
    //    else if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        transform.position -= transform.forward * speed;
    //    }
    //    else if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        transform.position += transform.right * speed;
    //    }
    //    else if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        transform.position -= transform.right * speed;
    //    }

    //}

}
