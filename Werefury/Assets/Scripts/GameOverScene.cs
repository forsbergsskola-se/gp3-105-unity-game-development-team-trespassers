using System;
using UI_Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace
{
    
    public class GameOverScene : MonoBehaviour
    {
        public Currency currency;
        
        private void Start()
        {   
            this.gameObject.SetActive(false);
        }

        public void GameOver()
        {
            gameObject.SetActive(true);
            this.
            currency.currency /= 2; 
            PlayerPrefs.SetInt("$$$",currency.currency);
            
            // save currency
        }
        public void Quit()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void CheckPoint()
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}