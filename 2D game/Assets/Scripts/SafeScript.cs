using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeScript : MonoBehaviour
{
    public GameObject OpenPanel;
    public GameObject Safe;

    void OnTriggerStay2D(Collider2D collision)
    {
        OpenPanel.SetActive(false);
        Safe.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //OpenPanel.SetActive(true);
        Safe.SetActive(false);
    }
}
