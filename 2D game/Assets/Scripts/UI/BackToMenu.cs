using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {

    public GameObject FadeIn;

    public void ToMainMenu()
	{
        FadeIn.SetActive(true);
        Time.timeScale = 1f;
        StartCoroutine(DelaySceneLoad());
	}

	IEnumerator DelaySceneLoad()
	{
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene("MainMenu");
	}
}