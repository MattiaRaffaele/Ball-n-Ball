//Questo script serve per far funzionare la vignette dinamica della slo mo ball


using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SlowMoManager : MonoBehaviour
{

    [SerializeField] GameObject PostProcessing;
    [SerializeField] GameObject SlowMoBall;

    public void PostProcessingOn()
    {
        Debug.Log("PostProcessing initialized");

        PostProcessing.GetComponent<PostProcessVolume>().GetComponent<Vignette>().intensity.value = 0.5f;
    }

    public void PostProcessingOff()
    {
        PostProcessing.GetComponent<PostProcessVolume>().GetComponent<Vignette>().intensity.value = 0.2f;
        Destroy(SlowMoBall);
    }
}
