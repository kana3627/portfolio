using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//シーン遷移ボタンのスクリプト
public class ButtonScr : MonoBehaviour
{

    public void OnClick()
    {
        Debug.Log("押された！");
        SceneManager.LoadScene("PlayScene");
    }
}
