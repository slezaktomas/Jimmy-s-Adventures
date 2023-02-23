using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public static Text timerText;
    public static float minutes;
    public static float seconds;
    public static bool finished = false;
    public float t;
    public static string timer;

    //Start je volán pøed první aktualizací snímku
    void Start()
    {
        timerText = GetComponent<Text>() as Text;
    }

    //Update se volá jednou za snímek
    void Update()
    {
        Counter();
        Finish();

    }
    void Counter() // Metoda èasovaè
    {
        if (finished) // Pokud dokonèime level, tak se zastavá èas a èasovaè se vynuluje
        {
            Time.timeScale = 0;
            t = 0;
            
        }

        // Zde se pøièítá èas
        t += Time.deltaTime;

        minutes = (int)( t / 60);
        seconds = (int)(t % 60);

        // Zde se èas zapisuje do stringu
        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        timer = timerText.text;




    }
    void Finish()
    {
        if (finished == true) // Pokud dokonèime level, tak se naète nová scéna
        {
            SceneManager.LoadScene(3);
        }

    }


}
