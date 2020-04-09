using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressToEnd : MonoBehaviour
{
    public GameObject fadeWhite;
    public GameObject lastText;
    public GameObject fadeBlack;
    public GameObject allControllers;
    public GameObject OpenPanel = null;

    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                fadeWhite.SetActive(true);
                allControllers.SetActive(false);
                StartCoroutine(ShowText());
            }
        }
    }

    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(4);
        lastText.SetActive(true);
        StartCoroutine(FadetoBlack());
    }

    IEnumerator FadetoBlack()
    {
        yield return new WaitForSeconds(8);
        fadeBlack.SetActive(true);
        StartCoroutine(ToCredits());
    }

    IEnumerator ToCredits()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Load Credits");
    }
}

