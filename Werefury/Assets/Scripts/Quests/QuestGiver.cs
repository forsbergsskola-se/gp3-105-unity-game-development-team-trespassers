using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public bool HasQuest = false;
    private bool inside;
    [SerializeField] private GameObject questUI;
    [SerializeField] public GameObject questObject;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("inside");
        inside = true;
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("outside");
        inside = false;
    }

    public void Update()
    {
        if (HasQuest)
        {
            questUI.SetActive(true);
            questObject.SetActive(false);
        }
        else
        {
            questUI.SetActive(false);
            questObject.SetActive(true);
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