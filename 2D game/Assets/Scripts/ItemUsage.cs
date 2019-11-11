using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUsage : MonoBehaviour
{
    //public GameObject effect;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use()
    {
        //Instantiate(effect, player.position, Quaternion.identity);
        Debug.Log("Item Used");
        //Destroy(gameObject);
    }
}
