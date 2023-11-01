using PlayerScripts;
using UnityEngine;
using UnityEngine.UI;
namespace UI_Scripts
{
    public class Currency : MonoBehaviour
    {
        public Text currencyAmount;
        public int currency;
        private PlayerSpawn newGame;

        private void Start()
        {
            currency = PlayerPrefs.GetInt("$$$");
            UpdateCurrency();
            // load currency
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
