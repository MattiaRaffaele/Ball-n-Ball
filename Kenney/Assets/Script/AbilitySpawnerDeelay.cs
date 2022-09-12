using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitySpawnerDeelay : MonoBehaviour
{
    [SerializeField] bool debug;

    [Header("Spawner settings:")]
    [SerializeField] GameObject spawner;
    [SerializeField] float Deelay;

    //Animation variables
    [Header("Text animations:")]
    [SerializeField] Animator textAnimator;
    [SerializeField] string animationName;



    private void Start()
    {
        if (!debug) StartCoroutine(spawnDeelay());
        else Destroy(gameObject);
    }

    IEnumerator spawnDeelay()
    {
        spawner.SetActive(false);

        yield return new WaitForSeconds(Deelay);
        Debug.Log("Deelayed ball is now spawned");

        spawner.SetActive(true);

        textAnimator.Play(animationName);
    }
}