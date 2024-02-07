using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_controller : MonoBehaviour
{
    private Animator anim;
    private bool isButtonAnimationPlayed = false; //���� �� ��� ��������� �������� ��������� ������
    private string nextSecondLevelName = "second_scene"; // �������� ��������� �����
    private string nextFirstLevelName = "first_scene";
    [SerializeField] AudioSource buttonActivateAudio;

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    public void PlayButtonAnimation()
    {
        if (isButtonAnimationPlayed == false)
        {
            buttonActivateAudio.Play();
            anim.Play("canvas_button_animation");
            isButtonAnimationPlayed = true;
        }
    }

    public void QuitGame()
    {
        Application.Quit(); // ����� �� ����������
    }

    // �������, ���������� ��� ������� ������
    public void LoadNextLevel()
    {
        // ���������, ��� ������ ��� ��������� �����
        if (!string.IsNullOrEmpty(nextSecondLevelName))
        {
            // ��������� ��������� �����
            SceneManager.LoadScene(nextSecondLevelName);
        }
        else
        {
            Debug.LogError("Next level name is not specified!");
        }
    }

    

    // ������������ �� ������ �����
    public void LoadPreviousLevel()
    {
        // ���������, ��� ������ ��� ��������� �����
        if (!string.IsNullOrEmpty(nextFirstLevelName))
        {
            // ��������� ���������� �����
            SceneManager.LoadScene(nextFirstLevelName);
        }
        else
        {
            Debug.LogError("Next level name is not specified!");
        }
    }
}
