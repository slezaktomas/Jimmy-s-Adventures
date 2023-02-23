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

    //Start je vol�n p�ed prvn� aktualizac� sn�mku
    void Start()
    {
        FslBattery = GetComponent<Text>() as Text;
    }

    //Update se vol� jednou za sn�mek
    void Update()
    {
        FlashlightSettings();
        FlashlightBattery();

    }


    void FlashlightSettings() // Metoda pro fungov�n� baterky
    {

        if (Input.GetMouseButtonDown(0)) //Pokud se stiskne lev� tla��tko my�i, tak se baterka zapne, hodnota FlashlightOn se nastav� na true, hodnota spriteNew se tak� nastav� na true a image.sprite se bude rovnat newSprite
        {
            Light.intensity = 1;
            FlashlightOn = true;
            spriteNew = true;
            image.sprite = newSprite;

        }

        if (Input.GetMouseButtonUp(0)) //Pokud se pust� lev� tla��tko my�i, tak se baterka vypne, hodnota FlashlightOn se nastav� na false, hodnota spriteNew se tak� nastav� na false a image.sprite se bude rovnat originalSprite
        {
            Light.intensity = 0;
            FlashlightOn = false;
            spriteNew = false;
            image.sprite = originalSprite;



        }
        if (Input.GetMouseButton(0)) //Pokud se dr�� lev� tla��tko my�i
        {
            if (FlashlightOn == true && Battery >= 1) // Pokud je baterka zapl�, a z�rove� je hodnota baterky v�t�� nebo rovno nule, tak se bude hodnota baterky ode��tat
            {
                Battery -= 0.5f;
            }
        }
        if (FlashlightOn == false && Battery <= 99) // Pokud je baterka vypl�, a z�rove� je hodnota baterky men�� nebo rovno 99, tak se bude hodnota baterky p�i��tat
        {
            Battery += 1.0f;

        }
        if (Battery == 1) // Pokud se hodnota baterky rovn� 1, tak se vypne, hodnota FlashlightOn se nastav� na false, image.sprite se bude rovnat originalSprite a hodnota spriteNew se bude rovnat false
        {
            Light.intensity = 0;
            FlashlightOn = false;
            image.sprite = originalSprite;
            spriteNew = false;
        }


    }

    void FlashlightBattery() //metoda pro vyps�n� textu hodnoty baterky
    {
        FslBattery.text = Battery.ToString("00") + "%";
    }

}
