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
    // Start is called before the first frame update

    void Update()
    {
        //Movimiento
        Raycasting();
        transform.position = Vector2.MoveTowards(transform.position, Target.position, 0);

    }
    void Raycasting()
    {
        Debug.DrawLine(CameraCuadrado.position, Player.position);
    }
}
