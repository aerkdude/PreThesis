using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoticonShowUp : MonoBehaviour
{
    public GameObject Emoticon;

    void OnTriggerStay2D(Collider2D collision)
    {
        Emoticon.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Emoticon.SetActive(false);
    }
}
