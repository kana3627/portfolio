using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//アイテム回収のスクリプト
public class itemScr : MonoBehaviour
{
    //アイテムを回収した時にSEを流す
    public AudioClip sound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            this.gameObject.SetActive(false);
            audioSource.PlayOneShot(sound);
        }
    }
}
