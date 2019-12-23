﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bTLimit = 10f;
    public float bTCollider = 3;
    public float bulletSpeed = 20f;
    public float countDown;
    Collider2D aCollider;

    void Start()
    {
        aCollider = GetComponent<Collider2D>();
        aCollider.isTrigger = true;
    }

    void Update()
    {
        //Switch up collider
        if (bTCollider > 0)
        {
            bTCollider--;
            if (bTCollider <= 0)
            {
                aCollider.isTrigger = false;
            }
        }

        //Que pasen 10s
        if (bTLimit > 0)
        {
            bTLimit -= 1 * Time.deltaTime;
            if (bTLimit <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        print("Collision");
        Destroy(gameObject);
    }
}
