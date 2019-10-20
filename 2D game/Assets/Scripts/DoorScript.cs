﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour {

	public GameObject OpenPanel = null;
    public Transform teLeportPosition;
    public DoorScript otherSide;

    void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Player")
		{			
            OpenPanel.SetActive(true);
		}
	}

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(false);
        }
    }

    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (IsOpenPanelActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Debug.Log("hit");
                GameObject player = GameObject.FindGameObjectWithTag("Player");

                //Debug.Log("NextRoom");
                player.transform.position = otherSide.teLeportPosition.position;

            }
        }
    }

}
