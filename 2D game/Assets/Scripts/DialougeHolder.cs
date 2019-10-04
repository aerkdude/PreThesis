using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeHolder : MonoBehaviour {

	public string dialouge;
	private DialougeManager dMan;

	// Use this for initialization
	void Start () {
		dMan = FindObjectOfType<DialougeManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2d(Collider2D other)
	{
		if (other.gameObject.name == "Player") 
		{
			if (Input.GetKeyDown(KeyCode.Space)) 
			{
				dMan.ShowBox(dialouge);
			}
		}
	}
}
