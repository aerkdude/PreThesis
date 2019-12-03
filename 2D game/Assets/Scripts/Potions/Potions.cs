using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : MonoBehaviour
{
    public GameObject Potion;
    public GameObject potionButton;
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

    private void OnTriggerStay2D(Collider2D other)
    {
        if (IsOpenPanelActive)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PickUp(transform);
            }
        }
    }

    public virtual void OnPickUp(Transform item)
    {
        PotionController.AmountHPSmall += 1;
        potionButton.SetActive(true);
        Destroy(gameObject);
    }

    void PickUp(Transform item)
    {
        OnPickUp(item);
    }
}
