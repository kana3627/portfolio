using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//目的地へ動かすスクリプト
public class DestinationScr : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject target; //目的地
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
