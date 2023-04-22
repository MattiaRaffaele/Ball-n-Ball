using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PPTCManager : MonoBehaviour
{

    /*
     * 0 = true
     * 1 = false
    */
    [SerializeField] GameObject errorWindow;
    [SerializeField] bool release;

    [SerializeField] private ErrorWindowProprieties errorWindowProprieties;
    
    
    private void Awake()
    {
        if (PlayerPrefs.GetInt("isFirstStartup") == 1 && release)
        {
            SceneManager.LoadScene("GameLoader");            
        }
    }

    public void Accept()
    {
        PlayerPrefs.SetInt("isFirstStartup", 1);
        StartGameVoid(1);
    }

    public void ShowPPTC(string ErrorMessage)
    {
        try
        {
            Process.Start("https://github.com/MattiaRaffaele/Ball-n-Ball/blob/main/PRIVACYPOLICY%26TERMSANDCONTIONS.md");
        }
        catch
        {
            ShowErrorWindow(ErrorMessage);
        }
    }

    public void ShowErrorWindow(string ErrorMessage)
    {
        errorWindowProprieties.errorMessage.text = ErrorMessage;
        errorWindowProprieties.gameObject.SetActive(true);
        errorWindowProprieties.gameObject.GetComponent<Animator>().SetTrigger("spawnWindow");
    }


    public void StartGameVoid(int sceneIndex)
    {
        StartCoroutine(StartGame(sceneIndex));
    }

    public IEnumerator StartGame(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            yield return null;
        }
    }
}
