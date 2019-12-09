using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    Animation Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animation>();
        Anim.Play("EndRollAnim");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
