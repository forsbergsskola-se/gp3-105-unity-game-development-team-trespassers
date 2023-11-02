using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{
    public Text killCount;
    public int kills;
    public QuestUI questKill;
    private QuestGiver gaveQuest;

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

        if (questKill.enabled)
        {
            questKill.AddQuestKill();
        }
            
    }
}