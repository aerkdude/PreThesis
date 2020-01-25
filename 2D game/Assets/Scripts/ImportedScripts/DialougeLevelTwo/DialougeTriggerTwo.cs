using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTriggerTwo : MonoBehaviour
{
    public Dialouge dialouge;
    public GameObject dialougeBox;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            FindObjectOfType<DialougeManagerTestTwo>().StartDialouge(dialouge);
            dialougeBox.SetActive(false);
        }
    }
}
