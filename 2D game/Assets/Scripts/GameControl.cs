﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    [SerializeField]
    private AudioSource winSound;

    public GameObject FadeIn;
    public static bool youWin;

    void Start ()
    {
        winText.SetActive(false);
        youWin = false;
    }

    void Update()
    {
        if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 &&
            pictures[6].rotation.z == 0 &&
            pictures[7].rotation.z == 0 &&
            pictures[8].rotation.z == 0)
        {
            youWin = true;
            winSound.Play();
            //winText.SetActive(true);
            FadeIn.SetActive(true);
            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("EndRoom");   
    }
}
