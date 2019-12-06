using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class gameController : MonoBehaviour
{

    public GameObject enemy;
    public GameObject enemy1;
    public GameObject textCntr;
    textScr text;

    void Start()
    {
        enemy = GameObject.Find("RedEnemy");
        enemy1 = GameObject.Find("PinkEnemy");

        textCntr = GameObject.Find("TextController");
        text = textCntr.GetComponent<textScr>();
    }


    void Update()
    {
        if (text.textFlg == true)
        {
            enemy.GetComponent<NavMeshAgent>().isStopped = true;
            enemy1.GetComponent<NavMeshAgent>().isStopped = true;
        }
    }
}
