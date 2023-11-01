using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour
{
    public Text QuestKills;
    public int questKills;
    public QuestGiver questGiver;
    private KillCount killCounted;

    private void Start()
    {
        questKills = 0;
    }

    private void Update()
    {
        if (questGiver.HasQuest && questKills <=4)
        {
            UpdateQuestKill();
            AddQuestKill();
        }
    }

    public void UpdateQuestKill()
    {
        QuestKills.text = $"Quest {questKills.ToString()}/4";
        Debug.Log("questKills: " + questKills);

        if (questKills >= 4)
        {
            QuestKills.text = " ";
        }
    }

    public void AddQuestKill()
    {
        questKills++;
    }
}