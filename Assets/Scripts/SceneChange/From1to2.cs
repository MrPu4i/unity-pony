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
        print($"{gm.GetStoryStatus("к спайку второй раз")}, {gm.GetStoryStatus("к спайку первый раз")}");
        if (gm.GetStoryStatus("к спайку второй раз"))
        {
            StartCoroutine(DialogueStart(dialogue_2));
            gm.ChangeStatusToFalse("к спайку второй раз");
            gm.ChangeStatusToTrue("в спальню");
            gm.ChangeStatusToFalse("второй раз в спальне");
            gm.ChangeStatusToTrue("в кровать");
        }
        else if (gm.GetStoryStatus("к спайку второй раз") == false && gm.GetStoryStatus("к спайку первый раз") == false)
        {
            if (leftWall == null)
            {
                return;
            }
            else
            {
                print("дошли до триггера");
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
