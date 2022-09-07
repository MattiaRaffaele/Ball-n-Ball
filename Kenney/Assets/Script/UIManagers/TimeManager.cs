using System.Collections;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{



    public TMP_Text timeText;

    int timerInt;

    bool execute = true;

    //PlayerPrefs
    string HighScore;
    int score;

    [SerializeField] TMP_Text highScoreText;


    private void Update()
    {
        
        timeText.text = timerInt.ToString();


        if (execute == true) StartCoroutine(deelay());

        

        IEnumerator deelay()
        {
            execute = false;

            timerInt++;
            CheckHighScore();
            yield return new WaitForSeconds(1);

            execute = true;
        }
    }

    void CheckHighScore()
    {        
        if (timerInt > PlayerPrefs.GetInt("HighScore"))
        {
            Debug.Log("High score!");
            PlayerPrefs.SetInt("HighScore", timerInt);
        }
    }
}
