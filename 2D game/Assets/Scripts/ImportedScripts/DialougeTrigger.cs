using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTrigger : MonoBehaviour
{
    public Dialouge dialouge;
    public GameObject dialougeBox;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<DialougeManagerTest>().StartDialouge(dialouge);
            dialougeBox.SetActive(false);
        }
    }
}
