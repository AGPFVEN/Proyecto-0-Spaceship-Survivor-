using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //Enemys 
    public GameObject NormalE;
    //Prefab number
    float spawnerNum;

    //Crono
    float crono;
    float cronoL;

    //Prefabs
    public GameObject spawnerDL;
    public GameObject spawnerDR;
    public GameObject spawnerUL;
    public GameObject spawnerUR;

    //Prefabs to number
    GameObject[] spawner;

    void Start()
    {
        //Crono (start)
        crono = 0;
        cronoL = 20;

        //Prefabs to number (start)
        spawner = new GameObject[3];
        spawner[0] = spawnerDL;
        spawner[1] = spawnerDR;
        spawner[2] = spawnerUL;
        spawner[3] = spawnerUR;

        //Prefab num (start)
        spawnerNum = Random.Range(0, 3);
    }

    void Update()
    {
        
    }
}