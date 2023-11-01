using System;
using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    public Text QuestKills;
    private QuestGiver GivenQuest;
    public int questKills;

    private void Start()
    {
        questKills = 0;
    }

    private void Update()
    {
        UpdateQuestKill();
        AddQuestKill();
    }

    public void UpdateQuestKill()
    {
            QuestKills.text = $"Quest {questKills.ToString()}/4";
            Debug.Log("questKills: " + questKills);
            if (questKills>=4)
            {
                QuestKills.text = " ";
            }
        
    }
    
public void AddQuestKill()
    {
        if (questKills <=3)
        {
            questKills++;
        }
        else
        {
            return;
        }
    }
}
