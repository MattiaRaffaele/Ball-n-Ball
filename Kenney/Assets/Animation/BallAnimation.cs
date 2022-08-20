using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnimation : MonoBehaviour
{



    private void Update()
    {
        gameObject.transform.Rotate(0, 0, Random.Range(0f, 90f), Space.Self);
    }
}
