using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //Enemys 
    public GameObject normalE;
    public GameObject normalC;
    GameObject actualC;

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
    public GameObject goSpawnerDL;
    public GameObject goSpawnerDR;
    public GameObject goSpawnerUL;
    public GameObject goSpawnerUR;
    public Transform oSpawnerDL;
    public Transform oSpawnerDR;
    public Transform oSpawnerUL;
    public Transform oSpawnerUR;
    public Transform oSpawnerU;

    //Prefabs to number
    Transform[] eSpawner;
    Transform[] oSpawner;

    //Modifying prefab
    float Xscale;
    float Yscale;

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
        oSpawner = new Transform[5];
        oSpawner[0] = oSpawnerDL;
        oSpawner[1] = oSpawnerDR;
        oSpawner[2] = oSpawnerUL;
        oSpawner[3] = oSpawnerUR;
        oSpawner[4] = oSpawnerU;

        //Prefab num (start)
        spawnerNum = Random.Range(0, 3);
        oSpawnerNum = Random.Range(0, 4);

        // //Modifying prefab (start)
        actualC = normalC;
    }

    void FixedUpdate()
    {
        //enemy algorithm
        if (crono <= 0)
        {
            Xscale = Random.Range(0, 5);
            Yscale = Random.Range(0, 5);
            actualC.transform.localScale = new Vector2(Xscale, Yscale);
            Instantiate(normalE, eSpawner[spawnerNum].position, Quaternion.Euler(0f, 0f, 0f));
            Instantiate(actualC, oSpawner[oSpawnerNum].position, transform.rotation);
            crono = 5;
            spawnerNum = Random.Range(0, 3);
            oSpawnerNum = Random.Range(0, 3);
            actualC = normalC;
        }
        if (crono >= 0)
        {
            crono -= 1 * Time.deltaTime;
        }
    }
}