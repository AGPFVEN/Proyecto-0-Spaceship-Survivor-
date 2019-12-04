using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesterMove : MonoBehaviour
{
    public Vector2 lookDirection;
    public float lookAngle;

    void FixedUpdate()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);
    }
}
