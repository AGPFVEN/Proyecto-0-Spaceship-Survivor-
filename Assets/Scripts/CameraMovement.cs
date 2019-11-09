using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform Target;
    public Transform Player;
    public Transform CameraCuadrado;
    public float movementSpeed;
    //Rigidbody2D rb;
    public Vector2 lookDirection;
    public float lookAngle;
    public float smoothSpeed = 1f;
    public Vector3 offset;
    // Start is called before the first frame update

    void Update()
    {
        //Movimiento
        Raycasting();
        //transform.position = Vector2.MoveTowards(transform.position, Target.position, 0);
        //new Vector2.Lerp();
        Vector3 desiredPosition = Target.position + offset;
        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = SmoothedPosition;

        transform.position = SmoothedPosition;
    }
    void Raycasting()
    {
        Debug.DrawLine(CameraCuadrado.position, Player.position);
    }
}
