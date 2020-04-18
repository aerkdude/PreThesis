using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCredits : MonoBehaviour
{
    public GameObject endText;
    public GameObject devText;
    public GameObject devTextTwo;
    public GameObject devTextThree;
    public GameObject fadeBlack;

    void Start()
    {
        StartCoroutine(EndTextShow());
    }

    IEnumerator EndTextShow()
    {
        yield return new WaitForSeconds(3);
        endText.SetActive(true);
        StartCoroutine(DevTextShow());
    }

    IEnumerator DevTextShow()
    {
        yield return new WaitForSeconds(8);
        devText.SetActive(true);
        StartCoroutine(DevTextTwoShow());
    }

    IEnumerator DevTextTwoShow()
    {
        yield return new WaitForSeconds(8);
        devTextTwo.SetActive(true);
        StartCoroutine(DevTextThreeShow());
    }

    IEnumerator DevTextThreeShow()
    {
        yield return new WaitForSeconds(8);
        devTextThree.SetActive(true);
        StartCoroutine(FadeBlackScreen());
    }

    IEnumerator FadeBlackScreen()
    {
        yield return new WaitForSeconds(12);
        fadeBlack.SetActive(true);
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }
}
