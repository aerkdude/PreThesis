using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public GameObject LandActive;
	public GameObject LandInActive;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
		LandActive.SetActive(true);
		other.gameObject.transform.position = spawnPoint.position;
		LandInActive.SetActive(false);
	}
}

