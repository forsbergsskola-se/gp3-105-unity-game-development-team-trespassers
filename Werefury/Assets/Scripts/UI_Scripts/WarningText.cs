using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WarningText : MonoBehaviour
{
    public Text textElement;
    public HP lowHealth;
    public void FixedUpdate()
    {
        
        if (lowHealth.hp <=25)
        {
            Debug.Log("Warning: Low Health!");
            textElement.enabled = true;
            textElement.text = "Warning: Low Health!";
        }
        if (lowHealth.hp <=15)
        {
            Debug.Log("Leave the car!");
            textElement.text ="Leave the car!";
        }
        if (lowHealth.hp <=10)
        {
            textElement.enabled = false;
        }
    }
}