using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private Animator change_level;

    [SerializeField] int levelToLoad; //�����, �� ������� �� ���������
    private void Start()
    {
        change_level = GetComponent<Animator>();//������� ��������
    }
    public void FadeToLevel()
    {
        //���������� ���������� ��� ��������
        change_level.SetTrigger("fade");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad); //��������� ����� �� ���������� � ����� ������
    }

}
