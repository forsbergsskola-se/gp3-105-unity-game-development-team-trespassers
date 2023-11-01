using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    public Text QuestKills;
    private QuestGiver GivenQuest;
    public int questKills =0;
    void Start()
    {
        QuestKills.enabled = false;
    }

    public void EnableQuestLog()
    {
        QuestKills.enabled = true;
        QuestKills.text =$"{questKills.ToString()}/4";
    }

    public void AddQuestKill()
    {
        QuestKills.text = $"{questKills++.ToString()}/4";
    }
}
