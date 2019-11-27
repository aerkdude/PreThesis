using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorToEpTwo : MonoBehaviour
{
    public GameObject OpenPanel = null;
    public GameObject EndScreen;
    public GameObject chaseBGM;
    public GameObject everything;

    [SerializeField] private AudioSource OpenSound;

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
                OpenSound.Play();
                EndScreen.SetActive(true);
                chaseBGM.SetActive(false);
                everything.SetActive(false);
            }
        }
    }
}
