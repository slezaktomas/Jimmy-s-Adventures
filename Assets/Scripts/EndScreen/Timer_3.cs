using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_3 : MonoBehaviour
{
    public static Text timer;
    //Start je vol�n p�ed prvn� aktualizac� sn�mku
    void Start()
    {
        timer = GetComponent<Text>() as Text;
    }

    //Update se vol� jednou za sn�mek
    void Update()
    {

        timer.text = "Last time: " + Timer.timer; // �as se vyp�e do textu
    }
}
