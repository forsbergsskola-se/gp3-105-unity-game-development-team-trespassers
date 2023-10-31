using UnityEngine;

namespace PlayerScripts
{
    public class PlayerSpawn : MonoBehaviour
    { 
        void Start() // you do this, when you load the level again
        {
            Vector3 position = new Vector3();
            
            if (!PlayerPrefs.HasKey("posX"))
                return;
            
            position.x = PlayerPrefs.GetFloat("posX");
            position.y = PlayerPrefs.GetFloat("posY");
            position.z = PlayerPrefs.GetFloat("posZ");
            // find player in the scene, e.g. FindObjectOfType
            // or GameObject.FindByTag, or GameObject.Find#

            GameObject player = GameObject.FindWithTag("Player");
            player.transform.position = position;

        }
    }
}