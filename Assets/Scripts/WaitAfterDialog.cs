using System.Collections;
using UnityEngine;

public class WaitAfterDialog : MonoBehaviour
{
    [SerializeField] LevelChanger lch;
    [SerializeField] GameManager gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(WaitForDialog());
    }

    IEnumerator WaitForDialog()
    {
        yield return new WaitForSeconds(16f);
        lch.FadeToLevel();
        gm.ChangeStatusToFalse("к спайку первый раз");
    }
}
