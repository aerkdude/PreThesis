using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToSecretRoomOne : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject nextText;

    void Start()
    {
        StartCoroutine(ShowText());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            fadeIn.SetActive(true);
            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(5);
        nextText.SetActive(true);
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("SecretRoomOne");
    }
}
