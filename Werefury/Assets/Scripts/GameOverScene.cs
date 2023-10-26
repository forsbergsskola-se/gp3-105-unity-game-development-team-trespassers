using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    
    public class GameOverScene : MonoBehaviour
    {
        

        private void Start()
        {
            this.gameObject.SetActive(false);
        }

        public void GameOver()
        {
            this.gameObject.SetActive(true);
        }
        public void Quit()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void CheckPoint()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}