﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour {

	public GameObject OpenPanel = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnTirggerEnter(Collider other) 
	{
		if (other.tag == "Player") 
		{
			Debug.Log("Hit");
		}
	}
}
