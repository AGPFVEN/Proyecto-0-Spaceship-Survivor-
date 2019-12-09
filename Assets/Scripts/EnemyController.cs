﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Transform Target;
    //Rigidbody2D rigidbody;
    Camera viewcamera;
    public GameObject Player;
    
    //Shift
    public float movementSpeed;

    //Turn
    public float lookAngle;
    public Vector2 lookDirection;

    //Player detection
    public float viewRadius;
    [Range(0, 360)]
    public float viewAngle;
    public Vector3 DirFromAngle(float  angleInDegrees)
    {
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }

    void start()
    {
        //rigidbody = GetComponent<Rigidbody2D> ();
        viewcamera = Camera.main;
    }

    void FixedUpdate()
    {
        //Rotation to look Player
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.DrawLine(transform.position, Target.position);
        lookDirection = Target.position - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        //Player detection
        

        //Movimiento
        //transform.position = Vector2.MoveTowards(transform.position, Target.position, movementSpeed * Time.deltaTime);
    }
}
