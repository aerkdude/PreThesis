using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchSetActive : MonoBehaviour
{
    public GameObject witchOne;
    public GameObject witchTwo;

    void Start()
    {
        StartCoroutine(WitchOneSetActive());
    }

    IEnumerator WitchOneSetActive()
    {
        yield return new WaitForSeconds(2);
        witchOne.SetActive(false);
        witchTwo.SetActive(true);
    }
}
