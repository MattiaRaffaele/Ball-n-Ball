using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour
{

    public GameObject Player;

    private void Start()
    {
        StartCoroutine(Deadline());
    }
    IEnumerator Deadline(){

        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<playerScript>().Death();
    }
}
