using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject OpenPanel = null;
    public GameObject KeyButton;
    public GameObject doorDialougeZone;
    public GameObject doorToBasement;
    public Dialouge dialouge;

    private void Start()
    {
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
                    FindObjectOfType<DialougeManagerTest>().StartDialouge(dialouge);
                    KeyButton.SetActive(true);
                    doorDialougeZone.SetActive(false);
                    doorToBasement.SetActive(true);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
 