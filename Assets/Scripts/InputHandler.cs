using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 GetTouchDeltaPosition()
    {
        if (Input.touchCount > 0)
        {
            return Input.GetTouch(0).deltaPosition;
        }

        return Vector2.zero;
    }

    public bool IsTouched()
    {
        return Input.touchCount > 0 ? true : false;
    }

    private void Update()
    {
        GetTouchDeltaPosition();
    }
}
