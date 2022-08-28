using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnimation : MonoBehaviour
{
    bool canRotate;
    private void Update()
    {
        

        if (canRotate) StartCoroutine(animation());
        IEnumerator animation()
        {
            canRotate = false;
            gameObject.transform.Rotate(0, 0, Random.Range(0f, 360f), Space.Self);
            yield return new WaitForSeconds(1);
            canRotate = true;
        }
    }
}
