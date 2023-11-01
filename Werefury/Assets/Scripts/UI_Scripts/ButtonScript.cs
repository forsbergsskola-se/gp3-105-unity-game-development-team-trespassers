using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void LoadScene()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Environment");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
