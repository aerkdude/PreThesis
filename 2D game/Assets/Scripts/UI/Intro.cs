using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public GameObject TextOne;
    public GameObject TextTwo;
    public GameObject TextThree;
    public GameObject TextFour;
    public GameObject TextFive;
    public GameObject SkipText;
    public GameObject PressText;
    public GameObject ButtonController;
    
    void Start()
    {
        StartCoroutine(LoadNextText());
    }

    IEnumerator LoadNextText()
    {
        yield return new WaitForSeconds(8);
        TextOne.SetActive(false);
        TextTwo.SetActive(true);
        StartCoroutine(LoadTextThree());
    }

    IEnumerator LoadTextThree()
    {
        yield return new WaitForSeconds(8);
        TextTwo.SetActive(false);
        TextThree.SetActive(true);
        StartCoroutine(LoadTextFour());
    }

    IEnumerator LoadTextFour()
    {
        yield return new WaitForSeconds(8);
        TextThree.SetActive(false);
        TextFour.SetActive(true);
        StartCoroutine(LoadTextFive());
    }

    IEnumerator LoadTextFive()
    {
        yield return new WaitForSeconds(8);
        TextFour.SetActive(false);
        TextFive.SetActive(true);
        StartCoroutine(LoadButton());
    }

    IEnumerator LoadButton()
    {
        yield return new WaitForSeconds(8);
        SkipText.SetActive(false);
        PressText.SetActive(true);
        ButtonController.SetActive(true);
    }
}
