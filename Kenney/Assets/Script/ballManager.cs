using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour
{

    public GameObject Player;

    [Range(0, 20)]
    public int durataSpawn;


    private void Start()
    {
        StartCoroutine(Deadline());
    }

    IEnumerator Deadline(){

        yield return new WaitForSeconds(durataSpawn);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<playerScript>().Death();
    }
}
