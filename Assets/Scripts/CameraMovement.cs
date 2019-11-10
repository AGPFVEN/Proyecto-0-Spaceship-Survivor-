﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5f;
    public float tLimit = 60;

    // Update is called once per frame
    void FixedUpdate()
    {
        ////Movimiento 
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0, 0);

        //Aceleración
        if (tLimit > 0)
        {
            tLimit -= Time.deltaTime;
            tLimit -= Time.deltaTime;
            tLimit -= Time.deltaTime;
            speed = speed + 1 * Time.deltaTime;
        }
    }
}
