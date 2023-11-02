using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    public Text QuestKills;
    public int questKills;
    private bool updateNeeded = false;

    private void Start()
    {
        questKills = 0;
    }

    private void Update()
    {
        if (updateNeeded)
        {
            UpdateQuestKill();
            updateNeeded = false;  // Reset the flag
        }
    }

    public void UpdateQuestKill()
    {
        QuestKills.text = $"Quest {questKills.ToString()}/4";
        Debug.Log("questKills: " + questKills);
        if (questKills >= 4)
        {
            QuestKills.text = "Quest 4/4";
        }
    }

    public void AddQuestKill()
    {
        questKills++;
        updateNeeded = true;  // Set the flag to indicate an update is needed
    }
}