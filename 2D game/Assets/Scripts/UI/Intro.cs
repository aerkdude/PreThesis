using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public GameObject TextOne;
    public GameObject TextTwo;
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
        yield return new WaitForSeconds(5);
        TextOne.SetActive(false);
        TextTwo.SetActive(true);
        StartCoroutine(LoadButton());
    }

    IEnumerator LoadButton()
    {
        yield return new WaitForSeconds(5);
        PressText.SetActive(true);
        ButtonController.SetActive(true);
    }
}
