using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManagerTwo : MonoBehaviour
{
    public GameObject tutorialBoxOne;
    public GameObject tutorialBoxTwo;
    public GameObject tutorialBoxThree;

    void Start()
    {
        StartCoroutine(ShowTutorial());
    }

    IEnumerator ShowTutorial()
    {
        yield return new WaitForSeconds(2);
        tutorialBoxOne.SetActive(true);
        StartCoroutine(ShowSecondTutorial());
    }

    IEnumerator ShowSecondTutorial()
    {
        yield return new WaitForSeconds(5);
        tutorialBoxOne.SetActive(false);
        tutorialBoxTwo.SetActive(true);
        StartCoroutine(ShowThirdTutorial());
    }

    IEnumerator ShowThirdTutorial()
    {
        yield return new WaitForSeconds(5);
        tutorialBoxTwo.SetActive(false);
        tutorialBoxThree.SetActive(true);
        StartCoroutine(CloseTutorial());
    }

    IEnumerator CloseTutorial()
    {
        yield return new WaitForSeconds(5);
        tutorialBoxThree.SetActive(false);
    }
}
