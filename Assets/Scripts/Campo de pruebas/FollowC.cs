using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowC : MonoBehaviour
{
    Transform Target;
    public GameObject Player;
    public float movementSpeed;
    public Vector2 lookDirection;
    public float lookAngle;

    void FixedUpdate()
    {
        //Rotation to look Player
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.DrawLine(transform.position, Target.position);
        lookDirection = Target.position - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        //Movimiento
        transform.position = Vector2.MoveTowards(transform.position, Target.position, movementSpeed * Time.deltaTime);
    }
}
