using UnityEngine.SceneManagement;
using UnityEngine;

public class RetryManager : MonoBehaviour
{
    int adSpawn;

    //public Interstitial interstitial;

    public GameObject Player;
    public GameObject RetryPanel;

    public void Retry()
    {
        //adSpawn = Random.Range(1, 4);
        //Debug.Log(adSpawn);



        //if (adSpawn == 1)
        //{
        //    interstitial.ShowAd();
        //}

        //Inizializza il gioco
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }

    public void Respawn()
    {
        Player.SetActive(true);
        RetryPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
