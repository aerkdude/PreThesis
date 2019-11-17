using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperPickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject OpenPanel = null;
    public GameObject itemButton;
    public GameObject DoorDialougeZone;
    public GameObject DoorToForest;

    //[SerializeField] private AudioSource PickUpSound;
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
                    //PickUpSound.Play();
                    gameObject.SetActive(false);
                    DoorDialougeZone.SetActive(false);
                    DoorToForest.SetActive(true);
                    break;
                }
            }
        }
    }
}
 