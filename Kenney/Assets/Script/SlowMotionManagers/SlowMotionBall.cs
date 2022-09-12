using System.Collections;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine;

public class SlowMotionBall : MonoBehaviour
{
    [SerializeField] float SlowMoDuration;
    private bool canSloMo = true;

    [SerializeField] Animator animSlowMo;

    


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

    private void SlowMotionBallID()
    {
        Debug.Log(Time.timeScale);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && canSloMo)
        {
            StartCoroutine(SlowMotion());



            IEnumerator SlowMotion()
            {
                canSloMo = false;


                animSlowMo.Play("SlowMoTook");

                GameObject[] SlowMoBall = GameObject.FindGameObjectsWithTag("SlowMoBall");
                for (int i = 0; i < SlowMoBall.Length; i++)
                    Destroy(SlowMoBall[i]);

                StartSlowMotion();


                yield return new WaitForSeconds(SlowMoDuration);


                StopSlowMotion();

                canSloMo = true;
                
                Destroy(gameObject);
            }
        }
    }
}