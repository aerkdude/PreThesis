using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperPickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject OpenPanel = null;
    public GameObject PaperButton;
    public GameObject tutorialBoxThree;
    public GameObject doorDialougeZone;
    public GameObject doorToForest;

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
                    PaperButton.SetActive(true);
                    tutorialBoxThree.SetActive(true);
                    doorDialougeZone.SetActive(false);
                    doorToForest.SetActive(true);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
 