using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AmmoScript : MonoBehaviour
{
    public Image ammoSprite;
    public Items.Items equpWeapon;

    private void Update()
    {
        if (equpWeapon.isEquipped)
        {
            ammoSprite.enabled = true;
        }
        else
        {
            ammoSprite.enabled = false;
        }
    }
}
