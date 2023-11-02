using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    public Text QuestKills;
    public int questKills;
    private bool updateNeeded = false;

    public void Start()
    {
        questKills=0;
    }

    public void Update()
    {
        if (updateNeeded)
        {
            UpdateQuestKill();
            updateNeeded = false;
        }
    }

    public void UpdateQuestKill()
    {
        QuestKills.text = $"Quest {questKills.ToString()}/4";
        //Debug.Log("questKills: " + questKills);
        if (questKills >= 4)
        {
            QuestKills.text = "Quest 4/4";
        }
    }

    public void AddQuestKill()
    {
        questKills++;
        updateNeeded = true; 
    }
}