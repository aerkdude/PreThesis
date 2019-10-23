using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public Transform spawnPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
		other.gameObject.transform.position = spawnPoint.position;	
	}
}

