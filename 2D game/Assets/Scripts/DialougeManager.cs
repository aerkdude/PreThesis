using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;
    
    public bool dialougeActive;

	
	void Start () {
		
	}
	
	
	void Update ()
    {
		if(dialougeActive && Input.GetKeyDown(KeyCode.Space))
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
