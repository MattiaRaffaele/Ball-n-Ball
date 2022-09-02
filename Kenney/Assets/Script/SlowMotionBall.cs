using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotionBall : MonoBehaviour
{
    [SerializeField] GameObject Spawner;
    [SerializeField] int SlowMoDuration;


    //slowmotion
    public float slowMotionTimescale;

    private float startTimescale;
    private float startFixedDeltaTime;


    void Start()
    {
        startTimescale = Time.timeScale;
        startFixedDeltaTime = Time.fixedDeltaTime;
    }

    private void StartSlowMotion()
    {
        Time.timeScale = slowMotionTimescale;
        Time.fixedDeltaTime = startFixedDeltaTime * slowMotionTimescale;
    }

    private void StopSlowMotion()
    {
        Time.timeScale = startTimescale;
        Time.fixedDeltaTime = startFixedDeltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(SlowMotion());



            IEnumerator SlowMotion()
            {
                Spawner.SetActive(false);
                StartSlowMotion();

                yield return new WaitForSeconds(SlowMoDuration);

                StopSlowMotion();
                Spawner.SetActive(true);
            }
        }
    }
}
