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
            healthBar.SetHealth(Hp.hp); 
            return Hp.hp;
        }

        public int HealDamage(int heal)
        {
            Hp.hp += heal;
            healthBar.SetHealth(Hp.hp);
            return Hp.hp;
        }

        private void Update()
        {
            if (Hp.hp <= 0)
            {
                Destroy(this.gameObject);
                gameOver.GameOver();
            }
        }
        
    }
