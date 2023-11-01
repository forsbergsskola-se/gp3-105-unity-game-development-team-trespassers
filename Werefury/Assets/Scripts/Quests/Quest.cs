using System;
using System.Collections;
using System.Collections.Generic;
using UI_Scripts;
using UnityEngine;

public class Quest : MonoBehaviour
{
    [SerializeField] private GameObject killCountGameObject;
    [SerializeField] private GameObject currencyCountGameObject;
    
    private QuestGiver questGiver;
    private KillCount killCount;
    private Currency currency;
    private int once = 0;

    private bool QuestComplete = false;

    private void Start()
    {
        GameObject Fountain = GameObject.FindWithTag("QuestGiver");
        questGiver = Fountain.GetComponent<QuestGiver>();
        killCount = killCountGameObject.GetComponent<KillCount>();
        currency = currencyCountGameObject.GetComponent<Currency>();
        
    }

    private void Update()
    {
       // Debug.Log(QuestCondition(killCount.kills));

       if (questGiver.HasQuest == true && QuestCondition(killCount.kills) && once == 0) ;
        {
            QuestComplete = true;
            currency.currency += 250;
            once++;
        }
    }

    private bool QuestCondition(int KillCount)
    {
       if (KillCount >= 4)
       { 
           return true;
       }
       else
       {
           return false;
       }
    }
}
