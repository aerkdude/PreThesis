using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour {

    public GameObject fadeIn;

    public void Exit()
	{
        fadeIn.SetActive(true);
		StartCoroutine(DelaySceneLoad());
	}

	IEnumerator DelaySceneLoad()
	{
		yield return new WaitForSeconds(4);
        Debug.Log("Exit");
		Application.Quit();
	}
}