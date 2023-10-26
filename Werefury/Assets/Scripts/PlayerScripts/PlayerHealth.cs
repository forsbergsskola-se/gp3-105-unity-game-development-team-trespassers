using System;
using DefaultNamespace;
using UI_Scripts;
using UnityEngine;

namespace PlayerScripts
{
    public class PlayerHealth : MonoBehaviour
    {
        public int hp;
        public HealthBar healthBar;
        public GameOverScene gameOver;

        private void Start()
        {
            hp = 100; 
            healthBar.SetHealth(hp); 
        }

        public int TakeDamage(int damage)
        {
            hp -= damage;
            healthBar.SetHealth(hp); 
            return hp;
        }

        public int HealDamage(int heal)
        {
            hp += heal;
            healthBar.SetHealth(hp);
            return hp;
        }

        private void Update()
        {
            if (hp <= 0)
            {
                Destroy(this.gameObject);
                gameOver.GameOver();
            }
        }
        
    }
}