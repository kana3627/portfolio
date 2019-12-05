using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerScr : MonoBehaviour
{

    public float speed = 0.1f;

    GameObject[] zanki;

    int zankiCount = 0;

    void Start()
    {

        zanki = new GameObject[4];
        for (int i = 0; i < 4; i++)
        {
            zanki[i] = GameObject.Find("Zanki" + (i));
        }
    }


    void Update()
    {
        Invoke("moveKey", 3.0f);

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
        if (other.tag == "redEnemy" || other.tag == "pinkEnemy" || other.tag == "lightBlueEnemy")
        {
            zanki[zankiCount].SetActive(false);
            zankiCount++;
        }

    }

    void moveKey()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed;
        }
    }

}
