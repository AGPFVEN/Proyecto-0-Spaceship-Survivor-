﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyController : MonoBehaviour
{
    //wall walking
    public LayerMask wallMask;
    bool walled;
    float wallDistance = 10f;
    Color disparo;
    RaycastHit enemyhit;

    //bool colActivated;
    bool changedone;

    //fire
    public GameObject Bullet;
    public Transform Barrel;
    float crono;
    float cronoL;

    //Destroyable
    int healthE;

    //Rigidbody2D rigidbody;
    Camera viewcamera;

    //Shift
    //float movementSpeed;

    //Turn
    float lookAngle;
    Vector2 lookDirection;

    //Player detection
    Transform Target;
    float viewRadius;
    float viewAngle;
    float distanceEP;
    float customdistanceEP;
    Vector3 rayVector;
    Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }

    void start()
    {
        //Collider
        changedone = false;

        //Cadencia
        customdistanceEP = 20;
        crono = 0;
        cronoL = 2;
        viewcamera = Camera.main;

        //movementSpeed = 0;
        Target = GameObject.FindGameObjectWithTag("Player").transform;

        //raycast color 
        disparo = Color.cyan;
    }

    void FixedUpdate()
    {
        if (healthE < 0)
        {
            Destroy(this.gameObject);
        }

        ////Rotation to look Player
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        lookDirection = Target.position - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        ////Player detection
        distanceEP = Vector2.Distance(transform.position, Target.position - transform.position);

        //Walled
        walled = Physics.CheckSphere(transform.position, wallDistance, wallMask);

        //Raycast
        rayVector = new Vector3((Target.position.x - transform.position.x), (Target.position.y - transform.position.y));
        Physics.Raycast(transform.position, rayVector, out enemyhit);
        Debug.DrawRay(transform.position, rayVector, Color.green);

        if (enemyhit.transform.tag == "Player" && !walled)
        {
            //Movimiento
            if (distanceEP > customdistanceEP)
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.position, 1.5f * Time.deltaTime);
            }

            //Disparo
            if (distanceEP <= customdistanceEP)
            {
                if (crono != cronoL)
                {
                    if (crono >= cronoL)
                    {

                        FiredBullet(Bullet);
                        crono = 0;

                    }
                    crono += 1 * Time.deltaTime;
                }
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, 1.5f * Time.deltaTime);
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Wall")
        {
            healthE -= 1;
        }
    }
    void FiredBullet(GameObject bullet)
    {
        GameObject firedbullet = Instantiate(bullet, Barrel.position, transform.rotation);
        firedbullet.GetComponent<Rigidbody2D>().velocity = transform.up * 20f;

    }
}