using UnityEngine;

namespace Items
{
    public class Items : MonoBehaviour
    {
        //This is on char
        [SerializeField] public GameObject HeldItem1;
        [SerializeField] public GameObject HeldItem2;
        [SerializeField] private GameObject YouCantdothat;
    
        // Add an item to the Hands
        private void Update()
        {
            ThrowWeapon();
            
        }
        public void AddItem(GameObject item)
        {
        
            if (HeldItem1 == null)
            {
                HeldItem1 = item;
            }
            else if (HeldItem2 = null)
            {
                HeldItem2 = item;
            }
            else
            {
                Instantiate(YouCantdothat);
            }
        }

        public void InitializeWeapon()
        {
            //ToDo Reference to Some Weapon Referencer hand 1 and hand 2, 
            //ToDo Initilize script on the component
        }

        public void ThrowWeapon()
        {
            if (Input.GetKey(KeyCode.G))
            {
                if (HeldItem1 != null)
                {
                    // TODO DROP Instantiate()
                    HeldItem1 = null;
                }
                else if (HeldItem2 != null)
                {
                    // TODO DROP Instantiate()
                    HeldItem2 = null;
                }
                else
                {
                    YouCantdothat.SetActive(true);
                }
            
            }
        }


  
    }
}


