using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    [Range(0,50)]
    public float scaleSpeed;


    public GameObject Camera;
    public GameObject RetryPanel;
    public Animator anim;


    private void Update()
    {
        //aumenta la scale del personaggio
        gameObject.transform.localScale = transform.localScale + new Vector3(1, 1, 1) * scaleSpeed * Time.deltaTime;
    }

    public void Death()
    {
        Time.timeScale = 0;
        gameObject.SetActive(false);
        RetryPanel.SetActive(true);
    }

    public void ScaleDown()
    {
        if (gameObject.transform.localScale.x >= 0f)
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