using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour {

	public GameObject OpenPanel = null;


	void Start () {
		
	}
	

	void Update () {
		
		
	}

	void OnTirggerEnter2D (Collider2D other) 
	{
		if (other.tag == "Player")
		{
			Debug.Log("Hit");
		}
	}
}
