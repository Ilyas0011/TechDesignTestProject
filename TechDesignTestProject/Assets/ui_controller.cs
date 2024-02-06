using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_controller : MonoBehaviour
{
    private Animator anim;
    private bool isButtonAnimationPlayed = false; //���� �� ��� ��������� �������� ��������� ������
    private string nextLevelName = "second_scene"; // �������� ��������� �����

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    public void PlayButtonAnimation()
    {
        if (isButtonAnimationPlayed == false)
        {
            anim.Play("canvas_button_animation");
            isButtonAnimationPlayed = true;
        }
    }

    // �������, ���������� ��� ������� ������
    public void LoadNextLevel()
    {
        // ���������, ��� ������ ��� ��������� �����
        if (!string.IsNullOrEmpty(nextLevelName))
        {
            // ��������� ��������� �����
            SceneManager.LoadScene(nextLevelName);
        }
        else
        {
            Debug.LogError("Next level name is not specified!");
        }
    }
}
