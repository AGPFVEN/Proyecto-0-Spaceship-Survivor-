﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnertest : MonoBehaviour
{
    public Transform place;
    public GameObject object2spawno;
    GameObject object2spawnm;

    public SpawnerScript SpawnerScript;
    Color thechosencolor;
    float Xscale;
    float Yscale;

    // Start is called before the first frame update
    void Start()
    {
        //object2spawno = object2spawnm;
        //SpawnerScript.RandomizeObstacle(object2spawnm);


        Instantiate(object2spawno, place.position, transform.rotation);
        thechosencolor = Color.green;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit testhit;
        Physics.Raycast(transform.position, transform.up, out testhit, 10f);
        Debug.DrawRay(transform.position, transform.up * 10, thechosencolor);

        //SpawnerScript.RandomizeObstacle();

        if (testhit.collider == false)
        {
            thechosencolor = Color.red;
        }
        else
        {
            thechosencolor = Color.green;
        }
    }
    void Createobstacles()
    {
        Instantiate(object2spawnm, place.position, Quaternion.Euler(0f, 0f, 0f));
    }
}