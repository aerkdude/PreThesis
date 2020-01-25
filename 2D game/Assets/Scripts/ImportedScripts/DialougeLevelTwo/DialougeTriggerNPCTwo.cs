using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTriggerNPCTwo : MonoBehaviour
{
    public GameObject OldHolder;
    public GameObject NewHolder;
    public GameObject OpenPanel = null;
    public GameObject dialougeTriggerBox;
    public Dialouge dialouge;


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

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                OpenPanel.SetActive(false);
                FindObjectOfType<DialougeManagerTestTwo>().StartDialouge(dialouge);
                OldHolder.SetActive(false);
                NewHolder.SetActive(true);
                dialougeTriggerBox.SetActive(true);
            }
        }
    }
}
