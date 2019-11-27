using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelPickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject OpenPanel = null;
    public GameObject shovelButton;
    public GameObject dialougeZone;
    public GameObject doorToUpstairOld;
    public GameObject doorToUpstairLock;
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
                    shovelButton.SetActive(true);
                    doorToUpstairOld.SetActive(false);
                    doorToUpstairLock.SetActive(true);
                    dialougeZone.SetActive(true);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
 