using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManagerPuzzleOne : MonoBehaviour
{
    public GameObject tutorialBoxOne;

    void Start()
    {
        StartCoroutine(ShowTutorial());
    }

    IEnumerator ShowTutorial()
    {
        yield return new WaitForSeconds(1);
        tutorialBoxOne.SetActive(true);
    }
}
