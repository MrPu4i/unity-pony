using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator dialog_text;
    public DialogueManager dm;

    public void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        dialog_text.SetBool("StartOpen", true);
    }
    public void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        dialog_text.SetBool("StartOpen", true);
    }
    public void OnTriggerExit2D(UnityEngine.Collider2D collision)
    {
        dialog_text.SetBool("StartOpen", false);
    }

}
