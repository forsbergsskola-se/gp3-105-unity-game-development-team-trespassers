using UnityEngine;
using UnityEngine.UI;
public class KillCount : MonoBehaviour
{
    public Text killCount;
    public static int kills;
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
    public static void AddKill() //Call AddKill to killable objects.
    {
        kills++;
    }
}