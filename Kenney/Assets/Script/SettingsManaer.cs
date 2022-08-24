using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManaer : MonoBehaviour
{


    public GameObject PostProcessing;
    bool PP = true;


    private void Update()
    {
        if (PP)
        {
            PostProcessing.SetActive(true);
        }
        else
        {
            PostProcessing.SetActive(false);
        }
    }


    public void GraphicPerformance()
    {
        PP = false;
    }
    public void GraphicGraphic()
    {
        PP = true;
    }
}
