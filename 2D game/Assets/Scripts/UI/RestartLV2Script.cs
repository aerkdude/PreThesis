using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLV2Script : MonoBehaviour {

    public GameObject fadeIn;

	public void Restart()
	{
        fadeIn.SetActive(true);
		StartCoroutine(DelaySceneLoad());
	}

	IEnumerator DelaySceneLoad()
	{
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene("BedRoomLvl2");
	}
}
