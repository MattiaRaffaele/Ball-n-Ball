using System.Collections;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class SlowMotionBall : MonoBehaviour
{
    [SerializeField] int SlowMoDuration;
    SlowMoManager slowMoManager;
    private bool canSloMo = true;


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
        if (collision.gameObject.tag == "Player" && canSloMo)
        {
            StartCoroutine(SlowMotion());



            IEnumerator SlowMotion()
            {
                canSloMo = false;
                StartSlowMotion();
                slowMoManager.PostProcessingOn();

                yield return new WaitForSeconds(SlowMoDuration);

                slowMoManager.PostProcessingOff();
                StopSlowMotion();

                canSloMo = true;
            }
        }
    }
}