using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_3 : MonoBehaviour
{
    public static Text timer;
    //Start je volán pøed první aktualizací snímku
    void Start()
    {
        timer = GetComponent<Text>() as Text;
    }

    //Update se volá jednou za snímek
    void Update()
    {

        timer.text = "Last time: " + Timer.timer; // èas se vypíše do textu
    }
}
