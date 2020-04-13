using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressToEnd : MonoBehaviour
{
    public GameObject OpenPanel = null;
    public GameObject tombStoneOld;
    public GameObject tombStoneNew;
    public GameObject whiteWitch;

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

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                tombStoneOld.SetActive(false);
                tombStoneNew.SetActive(true);
                whiteWitch.SetActive(true);
            }
        }
    }
}

