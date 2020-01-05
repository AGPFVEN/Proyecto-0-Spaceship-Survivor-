using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //Enemys 
    public GameObject normalE;
    //Prefab number
    int spawnerNum;

    //Crono
    float crono;
    float cronoL;

    //Prefabs
    public Transform spawnerDL;
    public Transform spawnerDR;
    public Transform spawnerUL;
    public Transform spawnerUR;

    //Prefabs to number
    Transform[] spawner;

    void Start()
    {
        //Crono (start)
        crono = 0;
        cronoL = 20;

        //Prefabs to number (start)
        spawner = new Transform[4];
        spawner[0] = spawnerDL;
        spawner[1] = spawnerDR;
        spawner[2] = spawnerUL;
        spawner[3] = spawnerUR;

        //Prefab num (start)
        spawnerNum = Random.Range(0, 3);
    }

    void FixedUpdate()
    {
        if (crono == 0)
        {
            Instantiate(normalE, spawner[spawnerNum].position, Quaternion.Euler(0f, 0f, 0f));
            crono = 5;
            spawnerNum = Random.Range(0, 3);
        }
        if (crono != 0)
        {
            crono -= 1 * Time.deltaTime;
        }
    }
}