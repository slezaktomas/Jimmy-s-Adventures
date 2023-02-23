using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;
public class Flashlight : MonoBehaviour
{

    public Light2D Light;
    public bool FlashlightOn = false;
    public Text FslBattery;
    public float Battery = 100;
    public Image image;
    public Sprite newSprite;
    public Sprite originalSprite;
    private bool spriteNew;
    float time = 0f;

    //Start je volán pøed první aktualizací snímku
    void Start()
    {
        FslBattery = GetComponent<Text>() as Text;
    }

    //Update se volá jednou za snímek
    void Update()
    {
        FlashlightSettings();
        FlashlightBattery();

    }


    void FlashlightSettings() // Metoda pro fungování baterky
    {

        if (Input.GetMouseButtonDown(0)) //Pokud se stiskne levé tlaèítko myši, tak se baterka zapne, hodnota FlashlightOn se nastaví na true, hodnota spriteNew se také nastaví na true a image.sprite se bude rovnat newSprite
        {
            Light.intensity = 1;
            FlashlightOn = true;
            spriteNew = true;
            image.sprite = newSprite;

        }

        if (Input.GetMouseButtonUp(0)) //Pokud se pustí levé tlaèítko myši, tak se baterka vypne, hodnota FlashlightOn se nastaví na false, hodnota spriteNew se také nastaví na false a image.sprite se bude rovnat originalSprite
        {
            Light.intensity = 0;
            FlashlightOn = false;
            spriteNew = false;
            image.sprite = originalSprite;



        }
        if (Input.GetMouseButton(0)) //Pokud se drží levé tlaèítko myši
        {
            if (FlashlightOn == true && Battery >= 1) // Pokud je baterka zaplá, a zároveò je hodnota baterky vìtší nebo rovno nule, tak se bude hodnota baterky odeèítat
            {
                Battery -= 0.5f;
            }
        }
        if (FlashlightOn == false && Battery <= 99) // Pokud je baterka vyplá, a zároveò je hodnota baterky menší nebo rovno 99, tak se bude hodnota baterky pøièítat
        {
            Battery += 1.0f;

        }
        if (Battery == 1) // Pokud se hodnota baterky rovná 1, tak se vypne, hodnota FlashlightOn se nastaví na false, image.sprite se bude rovnat originalSprite a hodnota spriteNew se bude rovnat false
        {
            Light.intensity = 0;
            FlashlightOn = false;
            image.sprite = originalSprite;
            spriteNew = false;
        }


    }

    void FlashlightBattery() //metoda pro vypsání textu hodnoty baterky
    {
        FslBattery.text = Battery.ToString("00") + "%";
    }

}
