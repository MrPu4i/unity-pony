using System.Collections;
using UnityEngine;

public class From1to2 : MonoBehaviour
{
    [SerializeField] DialogueManager dm;
    [SerializeField] Dialogue dialogue;
    [SerializeField] Dialogue dialogue_2;
    [SerializeField] Animator animator;
    [SerializeField] Animator leftWall;
    [SerializeField] GameManager gm;
    void Start()
    {
        print($"{gm.GetStoryStatus("� ������ ������ ���")}, {gm.GetStoryStatus("� ������ ������ ���")}");
        if (gm.GetStoryStatus("� ������ ������ ���"))
        {
            StartCoroutine(DialogueStart(dialogue_2));
            gm.ChangeStatusToFalse("� ������ ������ ���");
            gm.ChangeStatusToTrue("� �������");
            gm.ChangeStatusToFalse("������ ��� � �������");
            gm.ChangeStatusToTrue("� �������");
        }
        else if (gm.GetStoryStatus("� ������ ������ ���") == false && gm.GetStoryStatus("� ������ ������ ���") == false)
        {
            if (leftWall == null)
            {
                return;
            }
            else
            {
                print("����� �� ��������");
                leftWall.SetTrigger("isTrigger");
            }
            return;
        }
        else
        {
            StartCoroutine(DialogueStart(dialogue));
        }
    }

    IEnumerator DialogueStart(Dialogue dial)
    {
        yield return new WaitForSeconds(1.5f);
        animator.SetBool("StartOpen", true);
        yield return new WaitForSeconds(0.5f);
        dm.StartDialogue(dial);
    }
}
