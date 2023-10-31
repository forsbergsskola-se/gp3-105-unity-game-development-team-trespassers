using System;
using UI_Scripts;
using UnityEngine;
using Random = UnityEngine.Random;

//This Citizen should have some money to drop when killed.
public class Citizen : MonoBehaviour
{
    public HP Hp;
    [SerializeField] private int minMoney =10;
    [SerializeField] private int maxMoney =50;
    public KillCount killcount;


    public Currency currency;
    void Start()
    {
        
    }

    /*public void Update()
    { 
        //ToDo remove this 
        if (Hp.hp <= 0)
        {
            Debug.Log("A Citizen died");
            CitizenMoney();
            Destroy(gameObject);
            killcount.AddKill();
           
        }
    }*/

    public void OnDestroy()
    {
        Debug.Log("A Citizen died");
        CitizenMoney();
        killcount.AddKill();
    }
    
    public void CitizenMoney()
    {
        int moneyDrop = Random.Range(minMoney, maxMoney + 1);
        Debug.Log(moneyDrop + "$ Dropped");
        currency.currency += moneyDrop;
        currency.UpdateCurrency(); 
    }
}
