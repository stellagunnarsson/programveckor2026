using System.Collections;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public string[] dialogue;
    private int index = 0;

    public float wordSpeed;
    public bool playerIsClose;
    public int DialougeLength;


    // Update is called once per frame
    void Update()
    {
        if (DialougeLength >= 1)
        {
            if (!dialoguePanel.activeInHierarchy)
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
            else if (dialogueText.text == dialogue[index] && Input.GetKeyDown(KeyCode.E))
            {

                NextLine();
            }

        }
        else
        {
            dialoguePanel.SetActive(false);
            return;
        }


    }

    public void RemoveText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        if (index < dialogue.Length - 1 && DialougeLength >= 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
            DialougeLength = DialougeLength - 1;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                RemoveText();
            }

        }
    }



}