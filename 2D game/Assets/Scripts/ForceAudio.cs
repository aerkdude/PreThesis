using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceAudio : MonoBehaviour
{
    AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.clip = Resources.Load<AudioClip>("PaperFlip");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
