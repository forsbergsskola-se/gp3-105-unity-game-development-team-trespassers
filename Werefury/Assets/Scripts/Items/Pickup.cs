using UnityEngine;

public class Pickup : MonoBehaviour
{
    //this is on item
    // Reference to the inventory script
    public Items inventory;

    private void Start()
    {
        // Ensure that the inventory reference is set
        if (inventory == null)
        {
            Debug.LogWarning("Inventory reference is not set on the Pickup script.");
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // Check if the collider that entered the trigger is the player
        if (other.gameObject.CompareTag("Player"))
        {
            // Add the GameObject to the inventory
            inventory.AddItem(gameObject);

            //TODO ADD INSTANTIATE ON PLAYER?
            
            // Destroy the pickup GameObject
            gameObject.SetActive(false);
        }
    }
}