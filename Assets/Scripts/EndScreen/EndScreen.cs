using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScreen : MonoBehaviour
{
    public static Text Jumps;


    //Start je volán pøed první aktualizací snímku
    void Start()
    {
        Jumps = GetComponent<Text>() as Text;
        
    }

    //Update se volá jednou za snímek

    void Update()
    {
        Jumping();

        
    }

    void Jumping() // Metoda, kde se zastaví èas a poèet skokù se vypíše do textu
    {
        Time.timeScale = 0;
        Jumps.text = "Jumps: " + Movement.jumps.ToString("0");

    }
}
