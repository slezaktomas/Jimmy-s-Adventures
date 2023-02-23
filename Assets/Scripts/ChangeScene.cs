using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{

    public float changeTime;

    //Update se volá jednou za snímek
    void Update()
    {
        changeTime -= Time.deltaTime;
        if(changeTime <= 0) //Pokud nastane konec cutsény, tak se naète 2. scéna
        {
            SceneManager.LoadScene(2);
        }
        if (Input.GetKeyDown(KeyCode.Return)) //Pokud stiskneme Enter, tak se naète 2. scéna
        {
            SceneManager.LoadScene(2);


        }

    }
}
