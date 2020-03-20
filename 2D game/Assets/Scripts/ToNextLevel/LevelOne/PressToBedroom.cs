using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressToBedroom : MonoBehaviour
{
   public GameObject FadeIn;
    
   void Update()
   {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("Press");
            FadeIn.SetActive(true);
            StartCoroutine(LoadNextScene());
        }
   }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("BedRoom");
    }
}
