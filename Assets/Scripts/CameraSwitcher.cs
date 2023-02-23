using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CameraSwitcher : MonoBehaviour
{

    public GameObject room;
    public CinemachineVirtualCamera vcam;
    public bool isActive;
  

    private void OnTriggerEnter2D(Collider2D other) // Metoda pro trigger.
    {
        if(other.CompareTag("Player") && !other.isTrigger) // Pokud vejdeme s postavou s tagem player do box collideru a ještì se nespustil trigger, tak se hodnota isActive nastaví na true 
        {
            isActive = true;

            }
            
    }
    private void OnTriggerExit2D(Collider2D other) // metoda pro trigger
    {
        if (other.CompareTag("Player")) // Pokud vejdeme s postavou s tagem player do box collideru
        {
            if (other.CompareTag("Player") && !other.isTrigger)// Pokud vejdeme s postavou s tagem player do box collideru a ještì se nespustil trigger, tak se hodnota isActive nastaví na false
            {
                isActive = false;
            }
        }
    }

    private void FixedUpdate()
    {
        if (isActive) //Pokud je hodnota isActive true, tak se zapne virtuální kamera
        {
            vcam.enabled = true;
        }
        else //Pokud je hodnota isActive false, tak se vypne virtuální kamera
        {
            vcam.enabled = false;
        }
    }
}