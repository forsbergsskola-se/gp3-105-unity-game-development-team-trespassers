using System;
using UnityEngine;

namespace Items
{
    public class ItemPicture : MonoBehaviour
    {
        public GameObject player;
       
        [SerializeField] private Sprite[] weaponSprites;
        
        private Items items;
        private Weapon weapon1;
        private Weapon weapon2;

         public void FixedUpdate()
         {
             GetComponents();
         }

         public void GetComponents()
        {
            this.items = player.GetComponent<Items>();
            
            if(items.HeldItem1 != null)
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
            if (weapon1.weaponId == "1")
            {
                
            }
        }
    }
}
