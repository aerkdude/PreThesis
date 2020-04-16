using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockController : MonoBehaviour
{
    [SerializeField]
    private AudioSource winSound;

    public GameObject padLock;
    public GameObject safeObj;
    public GameObject keyObj;

    private int[] result, correctCombination;

    private void Start()
    {
        result = new int[] { 5, 5, 5 };
        correctCombination = new int[] { 3, 0, 1 };
        LockRotate.Rotated += CheckResults;
    }

    private void CheckResults(string wheelName, int number)
    {
        switch (wheelName)
        {
            case "Wheel1":
                result[0] = number;
                break;

            case "Wheel2":
                result[1] = number;
                break;

            case "Wheel3":
                result[2] = number;
                break;
        }
        if (result[0] == correctCombination[0] && result[1] == correctCombination[1] && result[2] == correctCombination[2])
        {
            //winText.SetActive(true);
            winSound.Play();
            StartCoroutine(ClosePadLock());
        }
    }

    private void OnDestroy()
    {
        LockRotate.Rotated -= CheckResults;
    }

    IEnumerator ClosePadLock()
    {
        yield return new WaitForSeconds(3);
        padLock.SetActive(false);
        safeObj.SetActive(false);
        keyObj.SetActive(true);
    }
}
