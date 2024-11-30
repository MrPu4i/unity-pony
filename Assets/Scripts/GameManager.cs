using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static Dictionary<string, bool> story;
    [SerializeField] private GameObject gameOver_Screen;
    private void Awake()
    {
        if (story == null)
        {
            story = new Dictionary<string, bool>()
            {
                {"в спальню", false}, //станет true после кат сцены с даванием лекарства, в конце игры
                {"из спальни", true}, //станет true, когда во второй раз зайдём, в конце игры
                {"к спайку первый раз", true}, //станет false когда поговорим с ним первый раз, потом станет false, когда соберём
                                    //все предметы станет true, и когда во второй раз поговорим опять false
                {"к спайку второй раз", false},
                {"спустились", false},
                {"второй раз в спальне", true},
                {"в кровать", false},
                {"после 2го раза от спайка в гостинную", false}
            };
        }
        else { return; }
    }
    void Start()
    {
        
    }
    public bool GetStoryStatus(string key)
    {
        if (story.ContainsKey(key))
        {
            return story[key];
        }
        else
        {
            print($"{key} не найден");
            return false;
        }
        
    }
    public void ChangeStatusToTrue(string key)
    {
        if (story.ContainsKey(key))
        {
            if (story[key] == false)
            {
                story[key] = true;
            }
            else
            {
                print($"{key} уже true");
            }
        }
    }
    public void ChangeStatusToFalse(string key)
    {
        if (story.ContainsKey(key))
        {
            if (story[key] == true)
            {
                story[key] = false;
            }
            else
            {
                print($"{key} уже false");
            }
        }
    }
    public void EndGame(Animator anim)
    {
        anim.SetTrigger("isTriggered");
    }
    public void EndGame_But_Close(Animator but)
    {
        but.SetBool("ButOpen", false);
    }
}
