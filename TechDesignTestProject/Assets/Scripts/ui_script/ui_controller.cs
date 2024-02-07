using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_controller : MonoBehaviour
{
    private Animator anim;
    private bool isButtonAnimationPlayed = false; //Была ли уже проиграна анимация появления кнопки
    private string nextSecondLevelName = "second_scene"; // Название следующей сцены
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
        Application.Quit(); // Выход из приложения
    }

    // Функция, вызываемая при нажатии кнопки
    public void LoadNextLevel()
    {
        // Проверяем, что задано имя следующей сцены
        if (!string.IsNullOrEmpty(nextSecondLevelName))
        {
            // Загружаем следующую сцену
            SceneManager.LoadScene(nextSecondLevelName);
        }
        else
        {
            Debug.LogError("Next level name is not specified!");
        }
    }

    

    // Возвращаемся на первую сцену
    public void LoadPreviousLevel()
    {
        // Проверяем, что задано имя следующей сцены
        if (!string.IsNullOrEmpty(nextFirstLevelName))
        {
            // Загружаем предыдущую сцену
            SceneManager.LoadScene(nextFirstLevelName);
        }
        else
        {
            Debug.LogError("Next level name is not specified!");
        }
    }
}
