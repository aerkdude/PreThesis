using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActiveEndMapOne : MonoBehaviour
{
    public GameObject FadeIn;
    public GameObject GameEndTitle;
    
    //public GameObject InActive;
    //[SerializeField] private AudioSource Sound;

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
            FadeIn.SetActive(true);
            //InActive.SetActive(false);
            //Sound.Play();
            StartCoroutine(LoadMenu());
        }
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3);
        GameEndTitle.SetActive(true);
    }
}

