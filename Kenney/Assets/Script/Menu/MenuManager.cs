using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void TutorialBtn()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitBtn()
    {
        Application.Quit();
    }
}
