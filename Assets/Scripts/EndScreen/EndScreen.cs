using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScreen : MonoBehaviour
{
    public static Text Jumps;


    //Start je vol�n p�ed prvn� aktualizac� sn�mku
    void Start()
    {
        Jumps = GetComponent<Text>() as Text;
        
    }

    //Update se vol� jednou za sn�mek

    void Update()
    {
        Jumping();

        
    }

    void Jumping() // Metoda, kde se zastav� �as a po�et skok� se vyp�e do textu
    {
        Time.timeScale = 0;
        Jumps.text = "Jumps: " + Movement.jumps.ToString("0");

    }
}
