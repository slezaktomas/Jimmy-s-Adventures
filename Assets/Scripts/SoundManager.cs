using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;

    //Start je volán pøed první aktualizací snímku
    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume",1);
        
        }

    }
    public void ChangeVolume() // Metoda pro zmìnu håasitosti hudby posouváním na slideru
    {
        AudioListener.volume = volumeSlider.value;
        
    }


}
