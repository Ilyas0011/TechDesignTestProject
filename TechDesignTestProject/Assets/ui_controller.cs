using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_controller : MonoBehaviour
{
    private Animator anim;
    private bool isButtonAnimationPlayed = false; //Была ли уже проиграна анимация появления кнопки
    private string nextLevelName = "second_scene"; // Название следующей сцены

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

    // Функция, вызываемая при нажатии кнопки
    public void LoadNextLevel()
    {
        // Проверяем, что задано имя следующей сцены
        if (!string.IsNullOrEmpty(nextLevelName))
        {
            // Загружаем следующую сцену
            SceneManager.LoadScene(nextLevelName);
        }
        else
        {
            Debug.LogError("Next level name is not specified!");
        }
    }
}
