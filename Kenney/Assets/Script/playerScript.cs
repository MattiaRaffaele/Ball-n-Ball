using System.Collections;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    [Range(0, 50)]
    public float scaleSpeed;

    ballSpawner ballSpawner;

    public GameObject RetryPanel;

    public GameObject JoyStick;

    private bool Arcade = true;



    private void Update()
    {
        if (gameObject.transform.localScale.x <= 0f)
        {
            Debug.Log("Scala annullata");
            gameObject.transform.localScale = new Vector3(0, 0, 0);
        }


        //aumenta la scale del personaggio
        gameObject.transform.localScale = transform.localScale + new Vector3(1, 1, 1) * scaleSpeed * Time.deltaTime;

        //Arcade
        if (Arcade) StartCoroutine(ArcadeIE());
        IEnumerator ArcadeIE()
        {
            Arcade = false;
            yield return new WaitForSeconds(15);
            Time.timeScale += 0.2f;
            Arcade = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Death();
        }
        else if (collision.gameObject.tag == "GoodGuy")
        {
            ScaleDown();
        }
        else if (collision.gameObject.tag == "Shield")
        {
            Shield();
        }
    }


    public void Death()
    {
        Debug.Log("Death triggered");
        JoyStick.SetActive(false);
        RetryPanel.SetActive(true);
        gameObject.SetActive(false);
        Time.timeScale = 0;

    }

    public void ScaleDown()
    {
        gameObject.transform.localScale -= new Vector3(1, 1, 1);
    }

    public void Shield()
    {
        SendMessage("Z");
    }
}