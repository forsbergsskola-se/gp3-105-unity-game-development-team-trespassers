using UnityEngine;

public class Pickup : MonoBehaviour
{
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

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Add the GameObject to the inventory
            inventory.AddItem(gameObject);

            // Destroy the pickup GameObject
            Destroy(gameObject);
        }
    }
}