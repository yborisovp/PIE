using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mopve : MonoBehaviour
{
    private Touch touch;

    private Vector2 touchPosition;

    private Quaternion rotationY;

    private Quaternion rotationX;

    private float rotateSpeedModifer = 0.01f;
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(
                    0f,
                    - touch.deltaPosition.x * rotateSpeedModifer,
                    0f);

                transform.rotation = rotationY * transform.rotation;
            }
        }
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationX = Quaternion.Euler(
                    - touch.deltaPosition.y * rotateSpeedModifer,
                    0f,
                    0f);

                transform.rotation = rotationX * transform.rotation;
            }
        }         
    }
}
