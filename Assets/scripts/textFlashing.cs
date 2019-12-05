using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//アタッチしたテキストを点滅させるスクリプト
public class textFlashing : MonoBehaviour
{
    public float speed;
    private Text text;
    private float time;
    public float r, g, b;
    private float a;
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
    }


    void Update()
    {
        //sin関数で点滅させる
        text.color = new Color(r, g, b, a);
        time += Time.deltaTime * speed;
        a = Mathf.Sin(time) * 1f;
    }
}
