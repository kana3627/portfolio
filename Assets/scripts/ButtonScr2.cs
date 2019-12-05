using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//チュートリアル画面に遷移するスクリプト
public class ButtonScr2 : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("tutorial");
    }
}
