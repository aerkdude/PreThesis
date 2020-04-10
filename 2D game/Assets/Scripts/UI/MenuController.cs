using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public GameObject startButton;
    public GameObject newGameButton;
    public GameObject chapterSelect;

	public void ClickNext()
	{
        startButton.SetActive(false);
        newGameButton.SetActive(true);
    }

    public void ClickBack()
    {
        startButton.SetActive(true);
        newGameButton.SetActive(false);
    }

    public void ChapterSelectButton()
    {
        newGameButton.SetActive(false);
        chapterSelect.SetActive(true);
    }

    public void ClickBackTwo()
    {
        newGameButton.SetActive(true);
        chapterSelect.SetActive(false);
    }
}
