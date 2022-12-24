using UnityEngine;

public class FPS : MonoBehaviour
{
    [Header("Framerate target")]
    [Tooltip("FPS Count you would like to have")]
    [SerializeField] int Fps;

    private void Start()
    {
        Application.targetFrameRate = Fps;
    }
}
