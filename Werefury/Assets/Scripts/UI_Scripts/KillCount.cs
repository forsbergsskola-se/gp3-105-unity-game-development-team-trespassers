using UnityEngine;
using UnityEngine.UI;
public class KillCount : MonoBehaviour
{
    public Text killCount;
    public int kills;
    void Start()
    {
        kills = 0;
    }
    void Update()
    {
        UpdateKillCount();
    }

    private void UpdateKillCount()
    {
        killCount.text = kills.ToString();
    }
    public  void AddKill() //Call AddKill to killable objects.
    {
        kills++;
    }
}
