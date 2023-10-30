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
            
            if (Input.GetKeyDown(KeyCode.R))
            {
                var weaponSpecific = HeldItem1.GetComponent<Weapon>();
                gunscript.Reload(weaponSpecific.weaponId);
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
            //Adds the Gun script.
            if(HeldItem1 != null && HeldItem1.CompareTag("Gun"))
            {
                myScript.enabled = true;
            }
            else if (HeldItem1 == null)
            {
                myScript.enabled = false;
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


