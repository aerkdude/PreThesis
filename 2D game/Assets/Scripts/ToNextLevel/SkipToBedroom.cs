using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipToBedroom : MonoBehaviour
{
   public GameObject FadeIn;
    
   void Update()
   {
        if(Input.GetKeyDown(KeyCode.Return))
        {
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
