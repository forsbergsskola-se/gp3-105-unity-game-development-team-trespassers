using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public bool HasQuest = false;

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(HasQuest);
        if (HasQuest == false && Input.GetKeyDown(KeyCode.K))
        {
            HasQuest = true;
            Debug.Log(HasQuest);
        }
    }
}
