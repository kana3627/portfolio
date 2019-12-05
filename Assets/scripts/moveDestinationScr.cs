using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ナビメッシュ の目的地をランダムに変更するスクリプト
public class moveDestinationScr : MonoBehaviour
{
    bool flg;

    void Start()
    {
        flg = false;
    }


    void Update()
    {
        Vector3 vec = new Vector3(Random.Range(1, 20), 0.4f, Random.Range(-1, -14));
        if (flg == false)
        {

            this.gameObject.transform.position = vec;
            flg = true;
            Debug.Log(vec);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "redEnemy")
        {
            flg = false;
        }
    }
}
