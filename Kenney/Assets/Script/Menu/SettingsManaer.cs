using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManaer : MonoBehaviour
{


    public GameObject PostProcessing;

    //PlayerPrefs
    private int GS;
    string GraphicSetting;



    private void Start()
    {
        PlayerPrefs.SetInt(GraphicSetting, GS);
    }

    private void Update()
    {
        Debug.Log(PlayerPrefs.GetInt(GraphicSetting));

        if (GS == 1)
        {
            PlayerPrefs.SetInt(GraphicSetting, 1);
            PostProcessing.SetActive(true);
        }
        
        else if (GS == 0)
        {
            PlayerPrefs.SetInt(GraphicSetting, 0);
            PostProcessing.SetActive(false);
        }
    }

    public void GraphicPerformance()
    {
        GS = 0;
    }
    public void GraphicGraphic()
    {
        GS = 1;
    }
}
