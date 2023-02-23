using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{


    //Update se vol� jednou za sn�mek
    void Update()
    {
        QuitToMainMenu();
    }
    void QuitToMainMenu() // Metoda pro ukon�en� hry do menu
    {
        if (Input.GetKeyDown(KeyCode.Return)) //Pokud stiskneme Enter, tak se na�te hlavn� menu sc�na, hodota finished se nastav� na false a po�et skok� se vynuluje
        {
            SceneManager.LoadScene(0);
            Timer.finished = false;
            Movement.jumps = 0;


        }
    }
    
}
