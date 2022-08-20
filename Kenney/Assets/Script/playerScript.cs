using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    private bool canScale;



    private void Start()
    {
        canScale = true;
    }

    private void Update()
    {
        if (canScale) StartCoroutine(scaleDeelay());
        IEnumerator scaleDeelay()
        {
            canScale = false;

            gameObject.transform.localScale += new Vector3(1, 1, 1) * 100 * Time.deltaTime;
            yield return new WaitForSeconds(5);

            canScale = true;
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }
}