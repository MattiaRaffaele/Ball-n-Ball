using System.Collections;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{



    public TMP_Text timeText;

    int timerInt;

    private void Update()
    {
        timeText.text = timerInt.ToString();

        timerInt += Time.deltaTime;
    }
}
