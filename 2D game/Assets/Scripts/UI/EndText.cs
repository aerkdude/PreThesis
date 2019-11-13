using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndText : MonoBehaviour 
{
	public GameObject EndMessage;
	public GameObject Player;
	public GameObject UIHealth;
	public GameObject MenuButton;
	public GameObject UILevel;

	private void OnTriggerEnter(Collider other)
	{
		EndMessage.SetActive(true);
		Player.SetActive(false);
		UIHealth.SetActive(false);
		MenuButton.SetActive(false);
		UILevel.SetActive(false);
	}
}
