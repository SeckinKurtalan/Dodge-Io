using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIWeapons : MonoBehaviour
{
    public static string silah;
    public static bool hand = false;

    public Sprite FlameThrower;
    public Sprite LazerGun;
    public Sprite Minigun;
    public Sprite Missle;
    public Sprite Shotgun;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeWeapon()
    {
        if (hand == true)
        {
            GetComponent<Image>().enabled = hand;
            if (silah == "FlameThrower(Clone)")
            {
                GetComponent<Image>().overrideSprite = FlameThrower;
            }
            else if (silah == "LazerGun(Clone)")
            {
                GetComponent<Image>().overrideSprite = LazerGun;
            }
            else if (silah == "Minigun(Clone)")
            {
                GetComponent<Image>().overrideSprite = Minigun;
            }
            else if (silah == "Missle(Clone)")
            {
                GetComponent<Image>().overrideSprite = Missle;
            }
            else if (silah == "Shotgun(Clone)")
            {
                GetComponent<Image>().overrideSprite = Shotgun;
            }

        }
        else
        {
            GetComponent<Image>().enabled = hand;
        }

    }
}
