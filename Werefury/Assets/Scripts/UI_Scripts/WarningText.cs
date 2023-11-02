using System;
using CarScripts;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WarningText : MonoBehaviour
{
    public Text textElement;
    private HP lowHealth;
    private Car isPlayerInCar;
    public void FixedUpdate()
    {
        
        if (lowHealth.value <=25)
        {
            Debug.Log("Warning: Low Health!");
            textElement.enabled = true;
            textElement.text = "Warning: Low Health!";
        }
        if (lowHealth.value <=15)
        {
            Debug.Log("Leave the car!");
            textElement.text ="Leave the car!";
        }
        if (lowHealth.value <=10)
        {
            textElement.enabled = false;
        }
    }
}