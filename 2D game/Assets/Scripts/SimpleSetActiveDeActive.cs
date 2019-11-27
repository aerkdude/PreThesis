using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSetActiveDeActive : MonoBehaviour
{
    public GameObject activeObj;
    public GameObject deActiveObj;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            activeObj.SetActive(true);
            deActiveObj.SetActive(false);
        }
    }
}
