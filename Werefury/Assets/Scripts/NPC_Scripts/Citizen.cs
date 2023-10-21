using UnityEngine;

public class Citizen : MonoBehaviour
{
    [SerializeField] private float maxHealth = 10f;
    [SerializeField] private float health;
    void Start()
    {
        health = maxHealth;
    }

    public void Update()
    {
        TakeDamage(10); //this can be called on the bullet, melee weapon or the player.-Adjust the damage.
        KillCount.AddKill();
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <=0)
        {
            Debug.Log("A Citizen died");
            Destroy(gameObject);
            
        }
    }
}
