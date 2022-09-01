using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{

    [SerializeField] private DebugScript debugScript;
    bool debug = false;

    [SerializeField] private GameObject PostProcessing;

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

    public void GraphicPerformance()
    {
        PlayerPrefs.SetInt("GraphicSetting", 0);
    }

    public void GraphicGraphic()
    {
        PlayerPrefs.SetInt("GraphicSetting", 1);
    }

    public void ControllerON()
    {
        PlayerPrefs.SetInt("Controller", 1);
    }
    public void ControllerOFF()
    {
        PlayerPrefs.SetInt("Controller", 0);
    }
}
