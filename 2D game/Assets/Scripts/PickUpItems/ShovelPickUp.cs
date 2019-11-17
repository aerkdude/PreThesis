﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelPickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject OpenPanel = null;
    public GameObject itemButton;
    public GameObject invWall;

    //AudioSource audioSource;

    //public AudioClip pickClip;

    private void Start()
    {
        //audioSource = GameObject.Find("PaperPickUp").GetComponent<AudioSource>();
        //audioSource.clip = pickClip;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }

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

    void OnTriggerStay2D(Collider2D collision)
    {
        if (IsOpenPanelActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                if (inventory.isFull[i] == false)
                   inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    //audioSource.Play();
                    gameObject.SetActive(false);
                    invWall.SetActive(true);
                    break;
                }
            }
        }
    }
}
 