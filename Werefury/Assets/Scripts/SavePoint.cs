using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class SavePoint : MonoBehaviour
    {
        public GameObject player;
        public bool saveActivated;

    
        public void OnCollisionEnter(Collision other)
        {
            if (other.gameObject == GameObject.FindGameObjectWithTag("Player"))
            {
                saveActivated = true;
                //player.transform.position = spawnPoint.position;
                SavingStuff();
            }
            
        }

        public void SavingStuff()
        {
            PlayerPrefs.SetFloat("posX", player.transform.position.x);
            PlayerPrefs.SetFloat("posY", player.transform.position.y);
            PlayerPrefs.SetFloat("posZ", player.transform.position.z);
            PlayerPrefs.Save();
        }
        
    }
}
   