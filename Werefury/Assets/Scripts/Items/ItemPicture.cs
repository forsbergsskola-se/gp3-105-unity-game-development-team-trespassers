using System;
using UnityEngine;
using UnityEngine.UI;

namespace Items
{
    public class ItemPicture : MonoBehaviour
    {
        public Image weieldImage;
        public GameObject player;

        [SerializeField] private Sprite[] weaponSprites;

        private Items items;
        private Weapon weapon1;
        private Weapon weapon2;

        private void Start()
        {
            weieldImage = GetComponent<Image>();
            weieldImage.sprite = null;
        }

        public void FixedUpdate()
        {
            GetComponents();
            ShowWeapon();
        }

        public void GetComponents()
        {
            this.items = player.GetComponent<Items>();

            if (items.HeldItem1 != null)
            {
                this.weapon1 = items.HeldItem1.GetComponent<Weapon>();

            }

            if (items.HeldItem2 != null)
            {
                this.weapon2 = items.HeldItem2.GetComponent<Weapon>();
            }

        }

        private void ShowWeapon()
        {
            if (weapon1 != null)
            {
                switch (weapon1.weaponId)
                {
                    case "1":
                        weieldImage.sprite = weaponSprites[1];
                        break;
                    case "2":
                        weieldImage.sprite = weaponSprites[2];
                        break;
                }
            }
            else
            {
                weieldImage.sprite = null;
            }
        }
    }
}
