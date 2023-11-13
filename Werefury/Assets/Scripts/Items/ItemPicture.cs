using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Items
{
    public class ItemPicture : MonoBehaviour
    {
        public Image weieldImage;
        public Image weieldImage2;
        public TextMeshProUGUI ammoText1;
        public TextMeshProUGUI ammoText2;
        public GameObject player;

        [SerializeField] private Sprite[] weaponSprites;

        private Items items;
        private Weapon weapon1;
        private Weapon weapon2;

        private void Start()
        {
            weieldImage.sprite = null;
            weieldImage2.sprite = null;
            Color weieldImageColor = weieldImage.color;
            weieldImageColor.a = 0f;
            weieldImage.color = weieldImageColor; 
            Color weieldImageColor2 = weieldImage.color;
            weieldImageColor2.a = 0f;
            weieldImage2.color = weieldImageColor; 
            
        }

        public void FixedUpdate()
        {
            GetComponents();
            ShowWeapon1();
            ShowWeapon2();
            ShowAmmo();
        }

        public void GetComponents()
        {
            this.items = player.GetComponent<Items>();

            if (items.HeldItem1 != null)
            {
                this.weapon1 = items.HeldItem1.GetComponent<Weapon>();
            }
            else
            {
                weapon1 = null;
            }

            if (items.HeldItem2 != null)
            {
                this.weapon2 = items.HeldItem2.GetComponent<Weapon>();
            }
            else
            {
                weapon2 = null;
            }
        }

        private void ShowWeapon1()
        {
            Color weieldImageColor = weieldImage.color;

            if (weapon1 != null)
            {
                switch (weapon1.weaponId)
                {
                    case "1":
                        weieldImage.sprite = weaponSprites[0];
                        weieldImageColor.a = 1f;
                        weieldImage.color = weieldImageColor; 
                        break;
                    case "2":
                        weieldImage.sprite = weaponSprites[1];
                        weieldImageColor.a = 1f;
                        weieldImage.color = weieldImageColor; 
                        break;
                    default:
                        weieldImage.sprite = null; 
                        weieldImageColor.a = 0f;
                        weieldImage.color = weieldImageColor; 
                        break;
                }
            }
            else
            {
                weieldImage.sprite = null;
                weieldImageColor.a = 0f;
                weieldImage.color = weieldImageColor; 
            }
        }
        
        private void ShowWeapon2()
        {
            Color weieldImageColor = weieldImage2.color;

            if (weapon2 != null)
            {
                switch (weapon2.weaponId)
                {
                    case "1":
                        weieldImage2.sprite = weaponSprites[0];
                        weieldImageColor.a = 1f;
                        weieldImage2.color = weieldImageColor; 
                        break;
                    case "2":
                        weieldImage2.sprite = weaponSprites[1];
                        weieldImageColor.a = 1f;
                        weieldImage2.color = weieldImageColor; 
                        break;
                    default:
                        weieldImage2.sprite = null; 
                        weieldImageColor.a = 0f;
                        weieldImage2.color = weieldImageColor; 
                        break;
                }
            }
            else
            {
                weieldImage2.sprite = null;
                weieldImageColor.a = 0f;
                weieldImage2.color = weieldImageColor; 
            }
        }

        private void ShowAmmo()
        {
            
            
            if (weapon1 != null)
            {
                string ammo1 = weapon1.mag.ToString();
                Debug.Log(ammo1);
                ammoText1.text = ammo1;
            }
            else
            {
                ammoText1.text = "";
            }
            
            
            
            if (weapon2 != null)
            {
                string ammo2 = weapon2.mag.ToString();
                ammoText2.text = ammo2;
            }
            else
            {
                ammoText2.text = "";
            }
        }

        
    }
}
