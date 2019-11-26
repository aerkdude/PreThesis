using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePressSetActive : MonoBehaviour
{
    public GameObject activeObj;
    public GameObject OpenPanel = null;

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
            activeObj.SetActive(true);
        }
    }
}
