using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackingScr : MonoBehaviour
{

    public GameObject plyr;  //player
    public GameObject dest;  //destination
    void Start()
    {
        plyr = GameObject.Find("player");
        dest = GameObject.Find("Destination");

        Debug.Log(dest);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            gameObject.GetComponent<DestinationScr>().target = plyr;  //敵の索敵範囲内に入ってきたら目的地をプレイヤに変える
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
            gameObject.GetComponent<DestinationScr>().target = dest;  //索敵範囲外に出たら、目的地を元に戻す
        }

    }
}
