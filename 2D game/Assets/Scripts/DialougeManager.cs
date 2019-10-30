using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour {

	public GameObject dBox;
	public Text dText;
    
    public bool dialougeActive;

    public string[] dialougeLines;
    public int currentLine;

    private PlayerMovement thePlayer;
	
	void Start () {
        thePlayer = FindObjectOfType<PlayerMovement>();
    }
	
	
	void Update ()
    {
		if(dialougeActive && Input.GetKeyDown(KeyCode.Space))
		{
            //dBox.SetActive(false);
            //dialougeActive = false;
            currentLine++;
        }

        if (currentLine >= dialougeLines.Length)
        {
            dBox.SetActive(false);
            dialougeActive = false;

            currentLine = 0;
            thePlayer.canMove = true;
        }

        dText.text = dialougeLines[currentLine];
    }

	public void ShowBox(string dialouge)
	{
		dialougeActive = true;
		dBox.SetActive (true);
		dText.text = dialouge;
	}

    public void ShowDialouge()
    {
        dialougeActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
    }
}
