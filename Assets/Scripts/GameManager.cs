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
                {"� �������", false}, //������ true ����� ��� ����� � �������� ���������, � ����� ����
                {"�� �������", true}, //������ true, ����� �� ������ ��� �����, � ����� ����
                {"� ������ ������ ���", true}, //������ false ����� ��������� � ��� ������ ���, ����� ������ false, ����� ������
                                    //��� �������� ������ true, � ����� �� ������ ��� ��������� ����� false
                {"� ������ ������ ���", false},
                {"����������", false},
                {"������ ��� � �������", true},
                {"� �������", false},
                {"����� 2�� ���� �� ������ � ���������", false}
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
            print($"{key} �� ������");
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
                print($"{key} ��� true");
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
                print($"{key} ��� false");
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
