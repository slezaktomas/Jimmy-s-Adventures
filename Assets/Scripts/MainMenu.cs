using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public void Play() //Metoda pro zapnut� prvn�ho levelu. Spust� se �as, na�te se sc�na prvn�ho levelui a hodnota ukon�en� levelu se nastav� na false
    {
        Timer.finished = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);


    }
    public void Quit() //Metoda pro ukon�en� hry
    {
        Application.Quit();
    }


}
