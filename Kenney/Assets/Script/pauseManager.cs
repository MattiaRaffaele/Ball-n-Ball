using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseManager : MonoBehaviour
{

    bool isPaused = false;

    [SerializeField] GameObject pausePanel;

    [Tooltip("joystickPanel: is the area where the joystick inputs are collected.\nIf it is activated buttons and other UI won't work")]
    [SerializeField] GameObject joystickPanel;

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
            joystickPanel.SetActive(false);
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
            joystickPanel.SetActive(true);
        }
    }

    public void ResumeBtn()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        joystickPanel.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
