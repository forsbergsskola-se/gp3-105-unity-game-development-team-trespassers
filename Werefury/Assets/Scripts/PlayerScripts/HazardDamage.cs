using Unity.VisualScripting;
using UnityEngine;

namespace PlayerScripts
{
   
    public class HazardDamage : MonoBehaviour
    {
        public PlayerHealth playerHealth;
        public int damage;

        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                playerHealth.hp -= damage;
            }
        }
        
        
    }
}