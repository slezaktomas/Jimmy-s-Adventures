using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{

    public float changeTime;

    //Update se vol� jednou za sn�mek
    void Update()
    {
        changeTime -= Time.deltaTime;
        if(changeTime <= 0) //Pokud nastane konec cuts�ny, tak se na�te 2. sc�na
        {
            SceneManager.LoadScene(2);
        }
        if (Input.GetKeyDown(KeyCode.Return)) //Pokud stiskneme Enter, tak se na�te 2. sc�na
        {
            SceneManager.LoadScene(2);


        }

    }
}
