using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    //это класс для триггера кнопок
    [SerializeField] Animator anim;
    [SerializeField] GameObject frame;
    [SerializeField] GameObject[] otherFrames;
    [SerializeField] GameManager gameManager;
    [SerializeField] public string key;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (key == "")
        {
            PlayerAction(other);
        }
        else if (gameManager.GetStoryStatus(key))
        {
            PlayerAction(other);
        }
        else { anim.SetBool("ButOpen", false); }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (key == "")
        {
            PlayerAction(other);
        }
        else if (gameManager.GetStoryStatus(key))
        {
            PlayerAction(other);
        }
        else { anim.SetBool("ButOpen", false); }
    }
    private void PlayerAction(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("ButOpen", true);
            //frame.SetActive(true);
            //foreach (GameObject frame in otherFrames)
            //{
            //    frame.SetActive(false);
            //}
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
            anim.SetBool("ButOpen", false);
        }
    }
}
