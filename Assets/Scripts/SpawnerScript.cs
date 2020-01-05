using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //Enemys 
    public GameObject normalE;
    public GameObject normalC;

    //Prefab number
    int spawnerNum;
    int oSpawnerNum;

    //Crono
    float crono;

    //Prefabs (enemy)
    public Transform spawnerDL;
    public Transform spawnerDR;
    public Transform spawnerUL;
    public Transform spawnerUR;

    //Prefabs (obstacles)
    public Transform oSpawnerDL;
    public Transform oSpawnerDR;
    public Transform oSpawnerUL;
    public Transform oSpawnerUR;

    //Prefabs to number
    Transform[] eSpawner;
    Transform[] oSpawner;

    void Start()
    {
        //Crono (start)
        crono = 0;

        //Enemy Prefabs to number (start)
        eSpawner = new Transform[4];
        eSpawner[0] = spawnerDL;
        eSpawner[1] = spawnerDR;
        eSpawner[2] = spawnerUL;
        eSpawner[3] = spawnerUR;

        //Obstacle Prefabs to number (start)
        oSpawner = new Transform[4];
        oSpawner[0] = oSpawnerDL;
        oSpawner[1] = oSpawnerDR;
        oSpawner[2] = oSpawnerUL;
        oSpawner[3] = oSpawnerUR;


        //Prefab num (start)
        spawnerNum = Random.Range(0, 3);
        oSpawnerNum = Random.Range( 0, 3);
        
    }

    void FixedUpdate()
    {
        //enemy algorithm
        if (crono <= 0)
        {
            Instantiate(normalE, eSpawner[spawnerNum].position, Quaternion.Euler(0f, 0f, 0f));
            crono = 5;
            spawnerNum = Random.Range(0, 3);
        }
        if (crono >= 0)
        {
            crono -= 1 * Time.deltaTime;
        }
    }
}