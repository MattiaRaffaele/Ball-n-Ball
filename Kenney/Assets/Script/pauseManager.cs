using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseManager : MonoBehaviour
{

    bool isPaused = false;

    public Animator anim;

    [SerializeField] GameObject pausePanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            PauseBtn();
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            ResumeBtn();
        }
    }

    public void PauseBtn()
    {
        if (!isPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
            anim.Play("resumeBtnAnimation");
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }
    }

    public void ResumeBtn()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
