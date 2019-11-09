using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform Target;
    public float smoothSpeed = 1f;
    public Vector3 offset;

    void Update()
    {
        //Movimiento
        Vector3 desiredPosition = Target.position + offset;
        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = SmoothedPosition;

        transform.position = SmoothedPosition;
    }
}
