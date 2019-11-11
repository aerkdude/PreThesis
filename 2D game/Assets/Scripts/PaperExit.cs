using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperExit : MonoBehaviour
{
    //public GameObject effect;
    private Transform player;
    public Image Paper;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //Paper = GameObject.Find("PaperTemp");
    }

    public void Use()
    {
        //Instantiate(effect, player.position, Quaternion.identity);
        //Debug.Log("Item Used");
        Paper.gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}
