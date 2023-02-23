using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public void Play() //Metoda pro zapnutí prvního levelu. Spustí se èas, naète se scéna prvního levelui a hodnota ukonèení levelu se nastaví na false
    {
        Timer.finished = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);


    }
    public void Quit() //Metoda pro ukonèení hry
    {
        Application.Quit();
    }


}
