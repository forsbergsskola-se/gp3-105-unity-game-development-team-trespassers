using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void DealDamage(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Citizen citizenComponent))
        {
            citizenComponent.TakeDamage(2);
        }
        Destroy(gameObject);
    }
}
