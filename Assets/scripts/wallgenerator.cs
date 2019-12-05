using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallgenerator : MonoBehaviour        //マップ生成のスクリプト
{

    //2次元配列でマップを生成する
    //参考にしたページhttps://qiita.com/yaju/items/5b54016c6574bc84c41d
    public GameObject wall;
    public GameObject item;
    public GameObject Sitem;
    public GameObject player;

    //マップの情報
    int[,] map =
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
    //処理が重くなってしまうので、最初に生成する
    void Start()
    {
        Vector3 vec = new Vector3(0, 0.5f, 0);        //生成する位置
        Vector3 vec1 = vec;                           //位置の初期化
        for (int i = 0; i < map.GetLength(0); i++)
        {

            vec.x = vec1.x;
            for (int j = 0; j < map.GetLength(1); j++)
            {
                //マップの数字が "1" なら壁を生成
                int a = map[i, j];
                if (a == 1)
                {
                    GameObject block = Instantiate(wall, vec, Quaternion.identity);
                    block.tag = "wall";
                }
                else if (a == 2)
                {
                    GameObject _item = Instantiate(item, vec, Quaternion.identity);
                    _item.tag = "item";
                }
                else if (a == 3)
                {
                    GameObject _Sitem = Instantiate(Sitem, vec, Quaternion.identity);
                    _Sitem.tag = "Sitem";
                }

                vec.x += wall.transform.localScale.x; //生成したら、x方向にオブジェクトのx幅分だけずらしていく
            }
            vec.z -= wall.transform.localScale.z;     ////生成したら、z方向にオブジェクトのz幅分だけずらしていく
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
