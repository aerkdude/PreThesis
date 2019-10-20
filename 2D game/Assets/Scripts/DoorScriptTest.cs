using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScriptTest : MonoBehaviour
{
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

    void Update()
    {
        if (IsOpenPanelActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");


                player.transform.position = otherSide.teLeportPosition.position;
            }
        }
    }
}
