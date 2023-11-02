using UnityEngine;
using UnityEngine.UI;

public class WarningText : MonoBehaviour
{
    public Text textElement;
    [SerializeField] HealthBar healthBarTracker;

    private void Start()
    {
        textElement.enabled = false;
    }

    private void Update()
    {
        if (healthBarTracker._currentHealth <= 0.5)
        {
            textElement.enabled = true; 
            textElement.text = "Warning: Low Health!";
        }
        else
        {
            textElement.enabled = false;
        }
    }
}