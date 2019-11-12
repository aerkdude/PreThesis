using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeHolderCollider : MonoBehaviour {

	public string dialouge;
	private DialougeManager dMan;
    public string[] dialougeLines;
    //public GameObject OpenPanel = null;

    // Use this for initialization
    void Start () {
		dMan = FindObjectOfType<DialougeManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") 
		{
            Debug.Log("Interacted");
            //dMan.ShowBox(dialouge);
            if (!dMan.dialougeActive)
            {
                dMan.dialougeLines = dialougeLines;
                dMan.currentLine = 0;
                dMan.ShowDialouge();
            }
        }
	}
}
