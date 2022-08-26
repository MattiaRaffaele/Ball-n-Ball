using TMPro;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{


    [SerializeField] TMP_Text highScoreText;

    private int HighScore;

    private void Update()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = HighScore.ToString();
    }
}
