using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PPTCManager : MonoBehaviour
{

    /*
     * 0 = true
     * 1 = false
    */

    private void Awake()
    {
        if (PlayerPrefs.GetInt("isFirstStartup") == 1)
        {
            SceneManager.LoadScene("GameLoader");            
        }
    }

    private void Accept()
    {
        PlayerPrefs.SetInt("isFirstStartup", 1);
    }

    public void ShowPPTC()
    {

    }
}
