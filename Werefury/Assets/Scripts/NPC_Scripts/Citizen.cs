using System;
using UI_Scripts;
using UnityEngine;
using Random = UnityEngine.Random;

public class Citizen : MonoBehaviour
{
    public HP Hp;
    [SerializeField] private int minMoney =10;
    [SerializeField] private int maxMoney =50;
    public KillCount killcount;
    public Currency currency;
    public int GetHP()
    {
        return Hp.value;
    }

    public void OnDestroy()
    {
        
        Debug.Log("A Citizen died");
        CitizenMoney();
        if (Hp.value<=0)
        {
            killcount.AddKill();
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
