using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{
    public Text killCount;
    public int kills;
    public QuestUI questKill;

    void Start()
    {
        kills = 0;
    }

    void Update()
    {
        UpdateKillCount();
    }

    public void UpdateKillCount()
    {
        killCount.text = $"{kills.ToString()}";
    }

    public void AddKill()
    {
        kills++;
        if (questKill.questGiver.HasQuest)  // Check if the quest is active
        {
            questKill.AddQuestKill();
        }
    }
}