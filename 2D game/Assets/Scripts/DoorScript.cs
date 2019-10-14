using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour {

	public GameObject OpenPanel = null;
    public Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Player")
		{
			
            OpenPanel.SetActive(true);
		}
	}

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(false);
        }
    }

    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }

    void Update ()
    {
        if(IsOpenPanelActive)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                //OpenPanel.SetActive(false);
                player.gameObject.transform.position = spawnPoint.position;
            }
        }
    }
}
