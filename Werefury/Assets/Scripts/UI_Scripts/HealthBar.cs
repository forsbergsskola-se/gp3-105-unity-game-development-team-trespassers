using System;
using PlayerScripts;
using UnityEngine;
using UnityEngine.UI;


    public class HealthBar : MonoBehaviour
    {
        public Image healthFill;
        [SerializeField] public Text healthText;
        public PlayerHealth playerHealth; // Reference for player health.
        public HP Hp;
        private int _maxHealth;
        public float _currentHealth;

        public void Start()
        {
            _maxHealth = Hp.value; // Set maxHealth using hp from PlayerHealth
        }

        public void Update()
        {
            _currentHealth = Hp.value; // Update currentHealth using hp from PlayerHealth
            UpdateHealthText();
            UpdateHealthBar();
        }

        public void UpdateHealthText()
        {
          healthText.text = _currentHealth.ToString(); // Update the health text
        }

        public void UpdateHealthBar()
        {
            float fillAmount = (float)_currentHealth / _maxHealth;
            healthFill.fillAmount = fillAmount;

            if (fillAmount > 0.75f)
            {
                healthFill.color = Color.green;
            }
            else if (fillAmount > 0.5f)
            {
                healthFill.color = Color.yellow;
            }
            else if (fillAmount > 0.25f)
            {
                healthFill.color = new Color(1.0f, 0.5f, 0.0f);
            }
            else
            {
                healthFill.color = Color.red;
            }
        }

        public void SetHealth(int newMaxHealth)
        {
            _maxHealth = newMaxHealth;
        }
    }
