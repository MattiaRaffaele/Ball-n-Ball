using System.Collections;
using UnityEngine.Profiling;
using UnityEngine;

public class ballManager : MonoBehaviour
{

    [SerializeField] GameObject Player;

    [SerializeField] float durataSpawn;


    private void Start()
    {
        Profiler.BeginSample("ballManager");
        StartCoroutine(Deadline());
    }


    IEnumerator Deadline(){

        yield return new WaitForSeconds(durataSpawn);
        Destroy(gameObject);
        Profiler.EndSample();
    }

    private void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<playerScript>().Death();
    }
}
