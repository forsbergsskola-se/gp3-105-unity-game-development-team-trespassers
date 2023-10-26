using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    
    public class GameOverScene : MonoBehaviour
    {
        GameObject gameOver;
        public void GameOver()
        {
            gameOver.SetActive(true);
        }
        public void Quit()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void CheckPoint()
        {
            
        }
    }
}