using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTime : MonoBehaviour
{
    //Update se vol� jednou za sn�mek
    void Update()
    {
        Start();
    }
    public void Start() //metoda pro start �asu
    {
        Time.timeScale = 1f;
    }
}
