using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{

    [SerializeField] TMP_Text versioncodeText;

    private void Update()
    {
        versioncodeText.text = Application.version;
    }
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
