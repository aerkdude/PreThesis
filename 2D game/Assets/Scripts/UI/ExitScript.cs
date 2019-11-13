using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour {

	public void Exit()
	{
		StartCoroutine(DelaySceneLoad());
	}

	IEnumerator DelaySceneLoad()
	{
		yield return new WaitForSeconds(1.0f);
		Application.Quit();
	}
}