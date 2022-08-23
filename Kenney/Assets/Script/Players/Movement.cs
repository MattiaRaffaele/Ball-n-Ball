using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    public float moveSpeed = 5f;
    Rigidbody2D rb;
    public JoyStick movementJoystick;




    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate() {
        if (movementJoystick.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.joystickVec.x * moveSpeed, movementJoystick.joystickVec.y * moveSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
