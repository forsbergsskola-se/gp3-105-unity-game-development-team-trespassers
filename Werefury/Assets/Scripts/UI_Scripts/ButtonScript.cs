using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Environment");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
