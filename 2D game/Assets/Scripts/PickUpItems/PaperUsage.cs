using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperUsage : MonoBehaviour
{
    private Transform player;
    public Image Paper;
    [SerializeField] private AudioSource clickSound;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        clickSound.Play();
        Paper.gameObject.SetActive(true);
    }

    public void Close()
    {
        clickSound.Play();
        StartCoroutine(CloseSelf());
    }

    IEnumerator CloseSelf()
    {
        yield return new WaitForSeconds(1);
        Paper.gameObject.SetActive(false);
    }
}
