using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitBtn()
    {
        Application.Quit();
    }
}
