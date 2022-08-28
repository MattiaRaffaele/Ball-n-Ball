using TMPro;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
    public bool DebugMode;
    [SerializeField] GameObject DebugPanel;

    [SerializeField] TMP_Text Debug_Version_Text;
    [SerializeField] TMP_Text Debug_TimeScale_Text;

    private void Update()
    {
        if (DebugMode)
        {
            Debug_TimeScale();
            Debug_Version();
        }
        else
        {
            DebugPanel.SetActive(false);
        }
    }

    void Debug_Version()
    {
        string app_name = Application.productName;
        string version = Application.version;

        Debug_Version_Text.text = app_name + version;
    }

    void Debug_TimeScale()
    {
        float TimeScale = Time.timeScale;

        Debug_TimeScale_Text.text = "TimeScale: " + TimeScale.ToString();
    }
}
