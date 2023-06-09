using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _3DRotation : MonoBehaviour
{
    private float rotationRate = 0.5f;

    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            Debug.Log("Touching at: " + touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch phase began at: " + touch.position);
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("Touch phase Moved");
                transform.Rotate(touch.deltaPosition.y * rotationRate,
                                 -touch.deltaPosition.x * rotationRate, 0, Space.World);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("Touch phase Ended");
            }
        }
    }
}
