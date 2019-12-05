using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//ナビメッシュを動的に生成するスクリプト

[DefaultExecutionOrder(-103)]
public class navmeshAwak : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<NavMeshSurface>().BuildNavMesh();

    }
}
