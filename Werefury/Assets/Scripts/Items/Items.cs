using Unity.VisualScripting;
using UnityEngine;

namespace Items
{
    public class Items : MonoBehaviour
    {
        [SerializeField] public Gunscript gunscript;
        
        //This is on char

        [SerializeField] public GameObject HeldItem1;
        [SerializeField] public GameObject HeldItem2;
        [SerializeField] private GameObject YouCantdothat;
        [SerializeField] public bool isEquipped = false;
        [SerializeField] public GameObject PlayerSprite;
        [SerializeField] private Sprite[] spriteArray;
        
    
        // Add an item to the Hands
        [SerializeField] private GameObject YouCantDoThatPrefab;
        [SerializeField] private Transform dropLocation;

        private void Update()
        {
            // Handle input to switch weapons
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                SwitchWeapon();
            }

            if (isEquipped =true)
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    var weaponSpecific = HeldItem1.GetComponent<Weapon>();
                    gunscript.Reload(weaponSpecific);
                }
                
            }
            

            // Handle input to throw the held item
            if (Input.GetKeyDown(KeyCode.G))
            {
                Drop();
            }
            InstantiateWeapon();
        }

        public void AddItem(GameObject item)
        {
        
            if (HeldItem1 == null)
            {
                HeldItem1 = item;
                isEquipped = true;
            }
            else if (HeldItem2 == null)
            {
                HeldItem2 = item;
            }
            else
            {
                Instantiate(YouCantdothat);
                // Instantiate the "YouCantDoThat" object when no slots are available.
            }
        }
        
        public void SwitchWeapon()
        {
            if (HeldItem1 != null && HeldItem2 != null)
            {
                GameObject tempItem = HeldItem1;
                HeldItem1 = HeldItem2;
                HeldItem2 = tempItem;
                
            }
        }
        
        public void InstantiateWeapon()
        {
            Gunscript myScript = GetComponent<Gunscript>();
            SpriteRenderer playerSprite = PlayerSprite.GetComponent<SpriteRenderer>();
            //Adds the Gun script.
            if(HeldItem1 != null && HeldItem1.CompareTag("Gun"))
            {
                myScript.enabled = true;
                isEquipped = true;
                var weaponSpecific = HeldItem1.GetComponent<Weapon>();
                switch (weaponSpecific.weaponId)
                {
                    case "1":
                        playerSprite.sprite = spriteArray[1];
                        break;
                    case "2":
                        playerSprite.sprite = spriteArray[2];
                        break;
                    default:
                        playerSprite.sprite = spriteArray[0];
                        break;
                }
            }
            else if (HeldItem1 == null)
            {
                myScript.enabled = false;
                isEquipped = false;
            }
            
        }
        
        public void Drop()
        {
            if (HeldItem2 != null && dropLocation != null)
            {
             
                GameObject droppedItem = Instantiate(HeldItem2, dropLocation.position, dropLocation.rotation);
                droppedItem.SetActive(true);
                HeldItem2 = null;
                
            }
            else if (HeldItem1 != null && dropLocation != null)
            {
                GameObject droppedItem = Instantiate(HeldItem1, dropLocation.position, dropLocation.rotation);
                droppedItem.SetActive(true);
                HeldItem1 = null;
            }
        }
        
    }
}


