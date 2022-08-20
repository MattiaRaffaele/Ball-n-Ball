using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    public GameObject Player;

    public Animator cameraAnim;

    private void Update()
    {
        if (Player.transform.localScale.x >= 10)
        {
            cameraAnim.Play("cameraAnimation_go");
        }
        else (Player.transform.localScale.x <= 9)
        {
            cameraAnim.Play("cameraAnimation_return");
        }
    }
}
