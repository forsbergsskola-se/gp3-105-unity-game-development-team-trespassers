using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public bool HasQuest = false;
    private bool inside;
    [SerializeField] private GameObject questUI;
    private QuestUI questUIComponent;

    private void Start()
    {
        questUIComponent = questUI.GetComponent<QuestUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("inside");
        inside = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("outside");
        inside = false;
    }

    private void Update()
    {
        if (HasQuest)
        {
            questUI.SetActive(true);
        }
        else
        {
            questUI.SetActive(false);
        }

        if (inside == true)
        {
            if (HasQuest == false && Input.GetKeyDown(KeyCode.K))
            {
                HasQuest = true;
                Debug.Log(HasQuest);
            }
        }
    }
}