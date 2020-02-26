using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToM : MonoBehaviour
{
    public GameObject FadeIn;
    public PlayerTwo playerTwo;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerTwo.GetComponent<Animator>().SetTrigger("Dead");
            playerTwo.canMove = false;
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(5);
        FadeIn.SetActive(true);
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MRoom");
    }
}
