using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public bool HasQuest = false;
    private bool inside;
    [SerializeField] private GameObject questUI;

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
        if (HasQuest == true)
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
