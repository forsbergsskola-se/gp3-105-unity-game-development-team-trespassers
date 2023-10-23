using UI_Scripts;
using UnityEngine;
//This Citizen should have some money to drop when killed.
public class Citizen : MonoBehaviour
{
    [SerializeField] private float maxHealth = 10f;
    [SerializeField] private float health;
    [SerializeField] private int minMoney =10;
    [SerializeField] private int maxMoney =50;

    public Currency currency;
    void Start()
    {
        health = maxHealth;
    }

    public void Update()
    { 
       
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <=0)
        {
            Debug.Log("A Citizen died");
            CitizenMoney();
            Destroy(gameObject);
        }
    }
    public void CitizenMoney()
    {
        int moneyDrop = Random.Range(minMoney, maxMoney + 1);
        Debug.Log(moneyDrop + "$ Dropped");
        currency.currency += moneyDrop;
        currency.UpdateCurrency(); 
    }
}
