using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryManager : MonoBehaviour
{
    int adSpawn;
    public GameObject adManager;

    [SerializeField] InterstitialAD interstitialAD;

    public void Retry()
    {
        adSpawn = Random.Range(1, 3);
        Debug.Log(adSpawn);

        if (adSpawn == 1)
        {
            interstitialAD.ShowAd();
        }
    }
}
