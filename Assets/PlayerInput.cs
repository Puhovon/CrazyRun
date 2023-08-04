using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    private Vector2 start;
    private Vector2 end;
    
    void Update()
    {
        
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                start = touch.position;
            }

            if (touch.phase == TouchPhase.Ended)
            {
                end = touch.position;
                if(start.x - end.x > 100f && Math.Abs(start.y - end.y) > 50f)
                    print("SWIPE LEFT");
                if(start.x - end.x < -100f && Math.Abs(start.y - end.y) > 50f)
                    print("SWIPE RIGHT");
            }
        }

        if (Input.touchCount == 2)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch secondTouch = Input.GetTouch(1);

            Vector2 tZeroPrevious = firstTouch.position - firstTouch.deltaPosition;
            Vector2 tSecondPrevious = secondTouch.position - secondTouch.deltaPosition;

            float oldTouchDistance = Vector2.Distance(tZeroPrevious, tSecondPrevious);
            float currentTouchDistance = Vector2.Distance(firstTouch.position, secondTouch.position);

            float deltaDistance = oldTouchDistance - currentTouchDistance;
            if(deltaDistance > 2)
                print("UNZOOM");
            if(deltaDistance < -2)
                print("ZOOM");
        }

        
    }
}
