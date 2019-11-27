using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSetActive : MonoBehaviour
{
    public GameObject activeObj;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
           
            activeObj.SetActive(true);
        }
    }
}
