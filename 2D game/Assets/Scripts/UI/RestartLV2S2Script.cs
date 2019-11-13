using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLV2S2Script : MonoBehaviour {

	public void Restart()
	{
		StartCoroutine(DelaySceneLoad());
	}

	IEnumerator DelaySceneLoad()
	{
		yield return new WaitForSeconds(1.0f);
		SceneManager.LoadScene("Level02_Stage02");
	}
}
