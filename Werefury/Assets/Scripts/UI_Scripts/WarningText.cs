using System;
using CarScripts;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WarningText : MonoBehaviour
{
    public Text textElement;
    public HP lowHealth;
    public void FixedUpdate()
    {
        
        if (lowHealth.value <=50)
        {
            Debug.Log("Warning: Low Health!");
            textElement.enabled = true;
            textElement.text = "Warning: Low Health!";
        }
        if (lowHealth.value <=0)
        {
            textElement.enabled = false;
        }
    }
}