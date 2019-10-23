using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportwFade : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject Fader;
    private Animator anim;

    void Awake()
    {
        anim = Fader.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FadeOut();
            other.gameObject.transform.position = spawnPoint.position;
            Invoke("FadeIn", 2.0f);
        }
    }

    void FadeOut()
    {
        anim.SetBool("FadeI", false);
        anim.SetBool("FadeO", true);
    }
    void FadeIn()
    {
        anim.SetBool("FadeO", false);
        anim.SetBool("FadeI", true);
    }
}
