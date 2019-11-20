using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperUsage : MonoBehaviour
{
    //public GameObject effect;
    private Transform player;
    public Image Paper;
    [SerializeField] private AudioSource PaperSound;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        //Instantiate(effect, player.position, Quaternion.identity);
        //Debug.Log("Item Used");
        PaperSound.Play();
        StartCoroutine(CloseSelf());
        Paper.gameObject.SetActive(true);
        //Destroy(gameObject);
    }

    IEnumerator CloseSelf()
    {
        yield return new WaitForSeconds(3);
        Paper.gameObject.SetActive(false);
    }
}
