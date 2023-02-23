using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    //Update se volá jednou za snímek
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Pokud stiskneme esc
        {
            if (GameIsPaused) // pokud se hodnota GameIsPaused rovná true, tak se zavolá metoda Resume
            {
                Resume();
            }
            else // pokud se hodnota GameIsPaused rovná false, tak se zavolá metoda Pause
            {
                Pause();
            }

        }
    }
    public void Resume() //Metoda pro vypnutí pause menu. Vypne se zde naše pause menu, èas se nastaví na jedna a hodnota GameIsPaused se nastaví na false
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause() //Metoda pro zapnutí pause menu. Zapne se zde naše pause menu, èas se nastaví na nula a hodnota GameIsPaused se nastaví na true
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu() // Metoda pro naètení hlavního menu
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");

    }

    public void QuitGame() // Metoda pro ukonèení hry
    {
        Application.Quit();

    }





}
