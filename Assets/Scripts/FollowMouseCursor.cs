using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class FollowMouseCursor : MonoBehaviour
{
    public float depth = 10.0f;
    public Light2D Light;


    //Start je volán pøed první aktualizací snímku
    void Start()
    {
        Cursor.visible = true;
        Light = GetComponent<Light2D>();
    }

    //Update se volá jednou za snímek
    void Update()
    {
        FollowMousePosition();
    }


    void FollowMousePosition() //Metoda pro následování kurzoru myši
    {
        var mousePos = Input.mousePosition;
        var wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, depth));
        transform.position = wantedPos;
    }
}
