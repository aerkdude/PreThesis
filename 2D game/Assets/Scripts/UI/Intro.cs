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
    public GameObject PressText;
    public GameObject ButtonController;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadNextText()
    {
        yield return new WaitForSeconds(10);
        TextOne.SetActive(false);
        TextTwo.SetActive(true);
        StartCoroutine(LoadTextThree());
    }

    IEnumerator LoadTextThree()
    {
        yield return new WaitForSeconds(10);
        TextTwo.SetActive(false);
        TextThree.SetActive(true);
        StartCoroutine(LoadTextFour());
    }

    IEnumerator LoadTextFour()
    {
        yield return new WaitForSeconds(10);
        TextThree.SetActive(false);
        TextFour.SetActive(true);
        StartCoroutine(LoadButton());
    }

    IEnumerator LoadButton()
    {
        yield return new WaitForSeconds(10);
        PressText.SetActive(true);
        ButtonController.SetActive(true);
    }
}
