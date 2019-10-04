using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;

	public bool dialougeActive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(dialougeActive && Input.GetKeyDown (KeyCode.Space))
		{
			dBox.SetActive(false);
			dialougeActive = false;
		}
	}

	public void ShowBox(string dialouge)
	{
		dialougeActive = true;
		dBox.SetActive (true);
		dText.text = dialouge;
	}
}
