using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTime : MonoBehaviour
{
    //Update se volá jednou za snímek
    void Update()
    {
        Start();
    }
    public void Start() //metoda pro start èasu
    {
        Time.timeScale = 1f;
    }
}
