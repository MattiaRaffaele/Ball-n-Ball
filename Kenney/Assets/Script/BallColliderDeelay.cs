using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColliderDeelay : MonoBehaviour
{
    bool canDeelay;


    private void Start()
    {
        StartCoroutine(ColliderDeelay());
    }

    IEnumerator ColliderDeelay()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<Collider2D>().enabled = true;
    }
}
