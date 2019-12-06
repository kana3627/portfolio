using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveScr : MonoBehaviour
{
    public float speed;
    void Start()
    {

    }


    void Update()
    {
        Invoke("moveKey", 3.0f);
    }
    void moveKey()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed;
        }

    }
}
