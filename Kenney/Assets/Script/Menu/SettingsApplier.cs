using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsApplier : MonoBehaviour
{


    [SerializeField] private GameObject PostProcessingManager;
    [SerializeField] private GameObject[] ControllerComponents;

    void Awake()
    {
        GraphicSettings();
        ControllerSettings();
    }

    private void GraphicSettings()
    {
        if (PlayerPrefs.GetInt("GraphicSetting") == 1)
        {
            PostProcessingManager.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("GraphicSetting") == 0)
        {
            PostProcessingManager.SetActive(false);
        }
    }
    private void ControllerSettings()
    {
        if (PlayerPrefs.GetInt("Controller") == 1)
        {
            ControllerComponents[0].transform.localScale = new Vector3(1, 1, 1);
            ControllerComponents[1].transform.localScale = new Vector3(1, 1, 1);
        }
        else if (PlayerPrefs.GetInt("Controller") == 0)
        {
            ControllerComponents[0].transform.localScale = new Vector3(0, 0, 0);
            ControllerComponents[1].transform.localScale = new Vector3(0, 0, 0);
        }
    }
}
