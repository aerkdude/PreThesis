using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayEndPic : MonoBehaviour
{
    public GameObject content;
    
    void Start()
    {
        StartCoroutine(DelayEndPicture());
    }

    IEnumerator DelayEndPicture()
    {
        yield return new WaitForSeconds(2);
        content.SetActive(true);
    }
}
