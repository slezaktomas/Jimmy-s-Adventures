using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{


    //Update se volá jednou za snímek
    void Update()
    {
        QuitToMainMenu();
    }
    void QuitToMainMenu() // Metoda pro ukonèení hry do menu
    {
        if (Input.GetKeyDown(KeyCode.Return)) //Pokud stiskneme Enter, tak se naète hlavní menu scéna, hodota finished se nastaví na false a poèet skokù se vynuluje
        {
            SceneManager.LoadScene(0);
            Timer.finished = false;
            Movement.jumps = 0;


        }
    }
    
}
