using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//UIを管理するスクリプト
public class textScr : MonoBehaviour
{
    public Text score;      //スコア
    public Text Ready;      //最初に出すreadyの文字
    public Text gameclear;  //アイテムを全部取り切ったら表示するテキスト
    public Text highScoreText;  //ハイスコアを表示する
    public Text NewHiscore;     //ハイスコアが更新された時に表示するテキスト

    public int scoreNum;    //スコアを表示する変数
    public int scoreCount;  //集めたアイテムの数

    private static int highScore;
    private string key = "HIGH SCORE";

    public bool textFlg = false;  //gameControlerにゲームが終了したことを伝えるフラグ

    GameObject[] itemObject; //シーン上にあるアイテムを保持する配列
    int itemNum;             //配列の要素数からシーン上にあるアイテムの数を求める

    void Start()
    {
        gameclear.enabled = false;
        NewHiscore.enabled = false;

        //itemタグがついてるオブジェクトの数をカウント
        itemObject = GameObject.FindGameObjectsWithTag("item");
        itemNum = itemObject.Length;

        highScore = PlayerPrefs.GetInt(key, 0);
        highScoreText.text = highScore.ToString();

    }


    void Update()
    {
        score.text = "SCORE:" + scoreNum;  //itemCountで渡された値と敵を食べた時の値を表示
        Invoke("readyDisplay", 3.0f);

        //集めたアイテム数が、シーン上にあるアイテムの数を超えたらgameclearの文字を表示
        if (scoreCount >= itemNum)
        {
            gameclear.enabled = true;
            textFlg = true;
            if (scoreNum > highScore)
            {
                NewHiscore.enabled = true;
                highScore = scoreNum;
                PlayerPrefs.SetInt(key, highScore);
                highScoreText.text = "HISCORE:" + highScore;
            }
        }

    }

    //readyの文字を非表示にする関数
    void readyDisplay()
    {

        Ready.enabled = false;
    }

}
