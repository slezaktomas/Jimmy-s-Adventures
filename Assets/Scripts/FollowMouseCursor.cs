using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class FollowMouseCursor : MonoBehaviour
{
    public float depth = 10.0f;
    public Light2D Light;


    //Start je vol�n p�ed prvn� aktualizac� sn�mku
    void Start()
    {
        Cursor.visible = true;
        Light = GetComponent<Light2D>();
    }

    //Update se vol� jednou za sn�mek
    void Update()
    {
        FollowMousePosition();
    }


    void FollowMousePosition() //Metoda pro n�sledov�n� kurzoru my�i
    {
        var mousePos = Input.mousePosition;
        var wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, depth));
        transform.position = wantedPos;
    }
}
