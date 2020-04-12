using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingUsage : MonoBehaviour
{
    private Transform player;
    public Image Ring;
    [SerializeField] private AudioSource clickSound;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        clickSound.Play();
        Ring.gameObject.SetActive(true);
    }
}
