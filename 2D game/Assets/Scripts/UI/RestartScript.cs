using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour {

    public GameObject FadeIn;

	public void Restart()
	{
        FadeIn.SetActive(true);
		StartCoroutine(DelaySceneLoad());
	}

	IEnumerator DelaySceneLoad()
	{
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene("BedRoom");
	}
}
