using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{
    public Text killCount;
    public int kills;
    [SerializeField] QuestGiver hasGivenQuest;
    [SerializeField] QuestUI questKills;
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
        if (hasGivenQuest.HasQuest==true)
        {
            questKills.AddQuestKill();
        }
    }
}