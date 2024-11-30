using UnityEngine;

public class ButTriggerEndGame : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameManager.GetStoryStatus("в спальню")) //можем только один раз в конце игры
        {
            PlayerAction(other);
        }
        else { return; }
    }
    private void PlayerAction(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("ButOpen", true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("ButOpen", false);
        }
    }
}
