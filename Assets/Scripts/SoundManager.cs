using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;

    //Start je vol�n p�ed prvn� aktualizac� sn�mku
    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume",1);
        
        }

    }
    public void ChangeVolume() // Metoda pro zm�nu h�asitosti hudby posouv�n�m na slideru
    {
        AudioListener.volume = volumeSlider.value;
        
    }


}
