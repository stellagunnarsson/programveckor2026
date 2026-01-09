using System.Collections;
using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public GameObject DialougePanel;
    public TextMeshProUGUI dialougeText;
    public string[] dialouge;
    private int index;

    public GameObject contButton;
    public float wordSpeed;
    public bool PlayerIsClose;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && PlayerIsClose)
        {
            if (DialougePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                DialougePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

        if (dialougeText.text == dialouge[index])
        {
            contButton.SetActive(true);
        }
    }

    public void zeroText()
    {
        dialougeText.text = "";
        index = 0;
        DialougePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialouge[index].ToCharArray())
        {
            dialougeText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {

        contButton.SetActive(false);

        if (index < dialouge.Length - 1)
        {
            index++;
            dialougeText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerIsClose = false;
            zeroText();
        }
    }
}
