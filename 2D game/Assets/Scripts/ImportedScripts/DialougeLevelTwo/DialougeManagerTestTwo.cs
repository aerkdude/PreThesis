using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManagerTestTwo : MonoBehaviour
{
    public Text nameText;
    public Text dialougeText;
    public GameObject dialougeBox;
    public GameObject healthBarLock;

    private Queue<string> sentences;
    private PlayerTwo thePlayer;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerTwo>();
        sentences = new Queue<string>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialouge (Dialouge dialouge)
    {
        thePlayer.canMove = false;
        dialougeBox.SetActive(true);
        healthBarLock.SetActive(true);

        nameText.text = dialouge.name;

        sentences.Clear();

        foreach (string sentence in dialouge.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialouge();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialougeText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialougeText.text += letter;
            yield return null;
        }
    }

    void EndDialouge()
    {
        dialougeBox.SetActive(false);
        healthBarLock.SetActive(false);
        thePlayer.canMove = true;
    }
}
