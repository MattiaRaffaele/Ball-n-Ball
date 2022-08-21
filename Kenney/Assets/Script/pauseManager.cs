using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseManager : MonoBehaviour
{

    bool isPaused;

    [SerializeField] GameObject pausePanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            pausePanel.SetActive(true);
            PauseBtn();
            isPaused = true;
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            pausePanel.SetActive(false);
            ResumeBtn();
            isPaused = false;
        }
    }

    public void PauseBtn()
    {
        Time.timeScale = 0;
    }

    public void ResumeBtn()
    {
        Time.timeScale = 1;
    }
}
