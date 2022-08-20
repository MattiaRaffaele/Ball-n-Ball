using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    private bool canScale;
    public GameObject Camera;



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
        Camera.GetComponent<CameraZoom>().enabled = false;
    }

    public void ScaleDown()
    {
        if (gameObject.transform.localScale.x >= 0)
        {
            gameObject.transform.localScale -= new Vector3(1, 1, 1) * 100 * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BadGuy")
        {
            Death();
        }
        else if (collision.gameObject.tag == "GoodGuy")
        {
            ScaleDown();
        }
    }
}