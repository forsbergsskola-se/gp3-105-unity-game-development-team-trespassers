using UnityEngine;
using UnityEngine.UI;
namespace UI_Scripts
{
    public class Currency : MonoBehaviour
    {
        public Text currencyAmount;
        public int currency;

        private void Start()
        {
            currency = 0;
        }

        private void Update()
        {
            UpdateCurrency();
        }
        public void UpdateCurrency()
        {
            currencyAmount.text = "$$$: " +currency;
            
        }
    }
}
