using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//プレイヤが敵に当たった時の処理
public class HitEnemy : MonoBehaviour
{
    public GameObject plyr;
    public GameObject enmy;

    playerScr playr;
    void Start()
    {
        plyr = GameObject.Find("player");
        enmy = GameObject.Find("RedEnemy");

        playr = plyr.GetComponent<playerScr>();

    }


    void Update()
    {
        if (playr.flg == true)
        {
            plyr.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
