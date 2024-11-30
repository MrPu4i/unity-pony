using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Items : MonoBehaviour
{
    private int Count_items;
    [SerializeField] Animator anim;
    [SerializeField] Animator anim_dialogue;
    [SerializeField] GameManager gm;
    [SerializeField] DialogueManager dm;
    [SerializeField] Dialogue[] dialogue;

    public void DisableButton(GameObject button)
    {
        button.SetActive(false);
    }
    public void PlusItem(int dialogue_number)
    {
        if (Count_items == 2)
        {
            dm.StartDialogue(dialogue[dialogue_number]);
            anim_dialogue.SetBool("StartOpen", true);
            anim.SetBool("ButOpen", true);
            return;
        }
        dm.StartDialogue(dialogue[dialogue_number]);
        anim_dialogue.SetBool("StartOpen", true);
        Count_items++;
    }


    public void MakeDrug(int dialogue_number) //нажимаемм кнопку для лекарства
    {
        gm.ChangeStatusToTrue("к спайку второй раз");
        anim.SetBool("ButOpen", false); //убираем кнопку эту
        dm.StartDialogue(dialogue[dialogue_number]);
        anim_dialogue.SetBool("StartOpen", true);
    }
}
