using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    private Animator change_level;

    [SerializeField] int levelToLoad; //сцена, на которую мы переходим
    private void Start()
    {
        change_level = GetComponent<Animator>();//находим анимацию
    }
    public void FadeToLevel()
    {
        //активирует затемнение при переходе
        change_level.SetTrigger("fade");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad); //загружаем сцену по указанному в юнити номеру
    }

}
