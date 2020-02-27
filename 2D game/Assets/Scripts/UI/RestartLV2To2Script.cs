using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLV2To2Script : MonoBehaviour {

    public GameObject FadeIn;

	public void Restart()
	{
        FadeIn.SetActive(true);
		StartCoroutine(DelaySceneLoad());
	}

	IEnumerator DelaySceneLoad()
	{
		yield return new WaitForSeconds(1.0f);
		SceneManager.LoadScene("BedRoomLvl2to2");
	}
}
