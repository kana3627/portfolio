using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//UIを管理するスクリプト
public class textScr : MonoBehaviour
{
    public Text score;          //スコア
    public Text Ready;          //最初に出すreadyの文字
    public Text gameclear;      //アイテムを全部取り切ったら表示するテキスト
    public Text highScoreText;  //ハイスコアを表示する
    public Text NewHiscore;     //ハイスコアが更新された時に表示するテキスト
    public Text countTime;           //時間

    public int scoreNum;    　　　　//スコアを表示する変数
    public int scoreCount;  　　　　//集めたアイテムの数
    public float countdown = 120; //カウントダウンの数
    private int timeScore;

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

        Invoke("readyDisplay", 3.0f);
        PlayerPrefs.DeleteKey("key");

    }


    void Update()
    {
        score.text = "SCORE:" + scoreNum;  //itemCountで渡された値と敵を食べた時の値を表示
        Invoke("startCountdown", 3.0f);
        countTime.text = "Time:" + countdown.ToString("f1");

        //集めたアイテム数が、シーン上にあるアイテムの数を超えたらgameclearの文字を表示
        if (scoreCount >= itemNum)
        {

            gameclear.enabled = true;
            textFlg = true;
            Time.timeScale = 0f;
            timeScore = scoreNum * (int)countdown;
            score.text = "SCORE:" + timeScore;

            if (timeScore > highScore)
            {
                NewHiscore.enabled = true;
                highScore = scoreNum;
                PlayerPrefs.SetInt(key, highScore);
                highScoreText.text = "" + highScore;
            }
        }

        //制限時間が０秒を超えたらゲームオーバー画面に遷移する
        if (countdown <= 0)
        {
            countdown = 0;
            SceneManager.LoadScene("gameOver");
        }

    }

    //readyの文字を非表示にする関数
    public void readyDisplay()
    {

        Ready.enabled = false;
    }

    void startCountdown()
    {
        countdown -= Time.deltaTime;
    }


}
