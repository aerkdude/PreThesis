using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePressPlaySound : MonoBehaviour
{
    [SerializeField] private AudioSource clickSound;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                clickSound.Play();
            }
        }
    }
}
