using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    //этот класс для триггера диалогов
    [SerializeField] Dialogue dialog;
    [SerializeField] Animator anim;
    [SerializeField] GameManager gameManager;
    [SerializeField] DialogueManager dm;
    [SerializeField] LevelChanger lch;

    public void TriggerDialog()
    {
        FindFirstObjectByType<DialogueManager>().StartDialogue(dialog);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameManager.GetStoryStatus("к спайку первый раз"))
        {
            PlayerAction(other);
            if (lch != null)
            {
                lch.FadeToLevel();
            }
            else { return; };
        }
        else if (gameManager.GetStoryStatus("к спайку второй раз"))
        {
            if (lch != null)
            {
                lch.FadeToLevel();
            }
            else { return; };
        }
        else { return; }
    }
    private void PlayerAction(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("StartOpen", true);
            dm.StartDialogue(dialog);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (anim == null)
            {
                return;
            }
            anim.SetBool("StartOpen", false);
        }
    }
}
