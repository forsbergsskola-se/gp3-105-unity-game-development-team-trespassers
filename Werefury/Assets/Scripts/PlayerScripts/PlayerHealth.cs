using System;
using DefaultNamespace;
using UI_Scripts;
using UnityEngine;


    public class PlayerHealth : MonoBehaviour
    {
        public HP Hp;
        public HealthBar healthBar;
        public GameOverScene gameOver;
        

        /*private void Start()
        {
            healthBar.SetHealth(Hp.hp); 
        }*/

        public int OnTakeDamage()
        {
            healthBar.SetHealth(Hp.value); 
            return Hp.value;
        }

        public int HealDamage(int heal)
        {
            Hp.value += heal;
            healthBar.SetHealth(Hp.value);
            return Hp.value;
        }

        private void Update()
        {
            if (Hp.value <= 0)
            {
                Destroy(this.gameObject);
                gameOver.GameOver();
                
            }
        }

       
    }
