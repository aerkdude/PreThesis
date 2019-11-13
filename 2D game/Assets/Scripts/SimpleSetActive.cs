using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSetActive : MonoBehaviour
{
    public GameObject Active;
    public GameObject InActive;
    [SerializeField] private AudioSource Sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Active");
            Active.SetActive(true);
            InActive.SetActive(false);
            Sound.Play();
        }
    }
}
