using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialBoxOne;
    public GameObject tutorialBoxTwo;
    
    void Start()
    {
        StartCoroutine(ShowTutorial());
    }

    IEnumerator ShowTutorial()
    {
        yield return new WaitForSeconds(1);
        tutorialBoxOne.SetActive(true);
        StartCoroutine(ShowSecondTutorial());
    }

    IEnumerator ShowSecondTutorial()
    {
        yield return new WaitForSeconds(2);
        tutorialBoxOne.SetActive(false);
        tutorialBoxTwo.SetActive(true);
        StartCoroutine(CloseTutorial());
    }

    IEnumerator CloseTutorial()
    {
        yield return new WaitForSeconds(3);
        tutorialBoxTwo.SetActive(false);
    }
}
