using UnityEngine;

public class FrameChange : MonoBehaviour
{
    [SerializeField] GameObject activeFrame;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            activeFrame.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (activeFrame == null)
            {
                return;
            }
            activeFrame.SetActive(false);
        }
    }
}
