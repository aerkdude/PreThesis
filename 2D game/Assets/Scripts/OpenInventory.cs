using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public GameObject Slots;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Slots.SetActive(true);
            StartCoroutine(CloseInvSlots());
        }
    }

    IEnumerator CloseInvSlots()
    {
        yield return new WaitForSeconds(5);
        Slots.SetActive(false);
    }
}
