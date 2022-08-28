using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManaer : MonoBehaviour
{

    [SerializeField] private DebugScript debugScript;
    bool debug = false;


    public void DebugMode()
    {
        if (debug)
        {
            debug = false;
            debugScript.DebugMode = false;
        }
        else if (!debug)
        {
            debug = true;
            debugScript.DebugMode = true;
        }
    }

    public void DeleteAllData()
    {
        PlayerPrefs.DeleteAll();
    }
}
