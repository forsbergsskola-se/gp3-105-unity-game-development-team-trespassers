using UnityEngine;
using UnityEngine.UI;

public class WarningText : MonoBehaviour
{
    public Text textElement;
    public HP healthBarTracker;
    

    private void Start()
    {
        textElement.enabled = false;
    }

    private void Update()
    {
        if (healthBarTracker.value <=50)
        {
            textElement.enabled = true; 
            textElement.text = "Warning: Low Health!";
        }
    }
}