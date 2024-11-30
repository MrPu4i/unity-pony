using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialog_name;
    public TextMeshProUGUI dialog_text;
    [SerializeField] GameManager gm;

    public Animator dialogAnim;

    private Queue<string> sentences;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        { 
            dialog_name.text = dialogue.name;
            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
            }
            DisplayNextSentence();
        }
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialog_text.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialog_text.text += letter;
            yield return null;
        }
        yield return new WaitForSeconds(3);
        DisplayNextSentence();
    }

    public bool EndDialogue()
    {
        dialogAnim.SetBool("StartOpen", false);
        print("закончился диалог");
        return true;
    }
}
