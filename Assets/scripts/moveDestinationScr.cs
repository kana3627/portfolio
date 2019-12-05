using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ナビメッシュ の目的地をランダムに変更するスクリプト
public class moveDestinationScr : MonoBehaviour
{
    bool flg;

    public GameObject obstacle;

    //マップの情報
    int[,] obstacleMap =
    {
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
        {1,3,2,2,2,2,1,2,2,2,2,2,2,2,1,2,2,2,2,3,1 },
        {1,2,1,1,1,2,1,2,1,1,1,1,1,2,1,2,1,1,1,2,1 },
        {1,2,2,2,1,2,2,2,2,2,1,2,2,2,2,2,1,2,2,2,1 },
        {1,2,1,2,1,1,1,1,1,2,1,2,1,1,1,1,1,2,1,2,1 },
        {1,2,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,2,1 },
        {1,2,1,1,1,2,1,2,1,1,0,1,1,2,1,2,1,1,1,2,1 },
        {1,2,1,2,2,2,2,2,1,0,0,0,1,2,2,2,2,2,1,2,1 },
        {1,2,1,2,1,1,1,2,1,0,0,0,1,2,1,1,1,2,1,2,1 },
        {1,2,1,2,2,2,2,2,1,1,1,1,1,2,2,2,2,2,1,2,1 },
        {1,2,1,2,1,1,1,2,2,2,2,2,2,2,1,1,1,2,1,2,1 },
        {1,2,1,2,2,2,1,2,1,2,1,2,1,2,1,2,2,2,1,2,1 },
        {1,2,1,2,1,2,1,2,1,1,1,1,1,2,1,2,1,2,1,2,1 },
        {1,2,0,2,1,3,2,2,2,2,2,2,2,2,2,3,1,2,2,2,1 },
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }


};
    void Start()
    {
        flg = false;

        Vector3 vec = new Vector3(0, 0.5f, 0);        //生成する位置
        Vector3 vec1 = vec;                           //位置の初期化
        for (int i = 0; i < obstacleMap.GetLength(0); i++)
        {

            vec.x = vec1.x;
            for (int j = 0; j < obstacleMap.GetLength(1); j++)
            {
                //マップの数字が "1" なら壁を生成
                int a = obstacleMap[i, j];
                if (a == 1)
                {
                    Instantiate(obstacle, vec, Quaternion.identity);
                }

                vec.x += obstacle.transform.localScale.x; //生成したら、x方向にオブジェクトのx幅分だけずらしていく
            }
            vec.z -= obstacle.transform.localScale.z;     ////生成したら、z方向にオブジェクトのz幅分だけずらしていく
        }

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
