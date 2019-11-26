using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperUsage : MonoBehaviour
{
    private Transform player;
    public Image Paper;
    [SerializeField] private AudioSource PaperSound;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        PaperSound.Play();
        StartCoroutine(CloseSelf());
        Paper.gameObject.SetActive(true);
    }

    IEnumerator CloseSelf()
    {
        yield return new WaitForSeconds(3);
        Paper.gameObject.SetActive(false);
    }
}
