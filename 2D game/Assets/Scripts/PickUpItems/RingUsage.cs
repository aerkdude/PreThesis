using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingUsage : MonoBehaviour
{
    private Transform player;
    public Image Ring;
    
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        StartCoroutine(CloseSelf());
        Ring.gameObject.SetActive(true);
    }

    IEnumerator CloseSelf()
    {
        yield return new WaitForSeconds(3);
        Ring.gameObject.SetActive(false);
    }
}
