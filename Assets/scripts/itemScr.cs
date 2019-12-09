using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//アイテム回収のスクリプト
public class itemScr : MonoBehaviour
{


    void Start()
    {

    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            this.gameObject.SetActive(false);

        }
    }
}
