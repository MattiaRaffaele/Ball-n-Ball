using System.Collections;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{



    public TMP_Text timeText;

    int timerInt;

    bool execute = true;


    private void Update()
    {
        timeText.text = timerInt.ToString();


        if (execute == true) StartCoroutine(deelay());

        IEnumerator deelay()
        {
            execute = false;

            timerInt++;
            yield return new WaitForSeconds(1);

            execute = true;
        }
    }
}
