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

    //Start je vol�n p�ed prvn� aktualizac� sn�mku
    void Start()
    {
        timerText = GetComponent<Text>() as Text;
    }

    //Update se vol� jednou za sn�mek
    void Update()
    {
        Counter();
        Finish();

    }
    void Counter() // Metoda �asova�
    {
        if (finished) // Pokud dokon�ime level, tak se zastav� �as a �asova� se vynuluje
        {
            Time.timeScale = 0;
            t = 0;
            
        }

        // Zde se p�i��t� �as
        t += Time.deltaTime;

        minutes = (int)( t / 60);
        seconds = (int)(t % 60);

        // Zde se �as zapisuje do stringu
        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        timer = timerText.text;




    }
    void Finish()
    {
        if (finished == true) // Pokud dokon�ime level, tak se na�te nov� sc�na
        {
            SceneManager.LoadScene(3);
        }

    }


}
