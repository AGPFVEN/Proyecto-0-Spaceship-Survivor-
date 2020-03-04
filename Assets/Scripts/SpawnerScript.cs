using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //Colores de los raycast
    Color chocaar;
    Color chocaab;
    Color chocade;
    Color chocaiz;
    Color chocaarde;
    Color chocaariz;
    Color chocaabde;
    Color chocaabiz;

    //modificar raycast
    float[] randomnumbers;

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
    public Transform oSpawnerDL;
    public Transform oSpawnerDR;
    public Transform oSpawnerUL;
    public Transform oSpawnerUR;

    //Prefabs to number
    Transform[] eSpawner;
    Transform[] oSpawner;

    //Modifying prefab
    float Xscale;
    float Yscale;

    void Start()
    {
        //Crono (start)
        crono = 1;

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

        //Prefab num (start)
        spawnerNum = Random.Range(0, 3);
        actualC = normalC;
        oSpawnerNum = Random.Range(0, 4);

        //first spawn 
        RandomizeObstacle(actualC);
        Instantiate(actualC, oSpawner[0].transform.position, transform.rotation);
        RandomizeObstacle(actualC);
        Instantiate(actualC, oSpawner[1].transform.position, transform.rotation);
        RandomizeObstacle(actualC);
        Instantiate(actualC, oSpawner[2].transform.position, transform.rotation);
        RandomizeObstacle(actualC);
        Instantiate(actualC, oSpawner[3].transform.position, transform.rotation);
        Xscale = Random.Range(0, 5);
        Yscale = Random.Range(0, 5);
        actualC.transform.localScale = new Vector2(Xscale, Yscale);
        Instantiate(normalE, eSpawner[spawnerNum].position, Quaternion.Euler(0f, 0f, 0f));
        Instantiate(actualC, oSpawner[oSpawnerNum].position, transform.rotation);
        spawnerNum = Random.Range(0, 3);
        oSpawnerNum = Random.Range(0, 3);
    }

    void FixedUpdate()
    {
        RaycastHit arriba, abajo, derecha, izquierda, arribade, arribaizq, abajode, abajoizq;

        //Arriba
        Physics.Raycast(transform.position, transform.up, out arriba, 10);
        Debug.DrawRay(transform.position, transform.up * 10, chocaar);

        //Abajo
        Physics.Raycast(transform.position, -transform.up, out abajo, 10);
        Debug.DrawRay(transform.position, -transform.up * 10, chocaab);

        //Derecha
        Physics.Raycast(transform.position, transform.right, out derecha, 10);
        Debug.DrawRay(transform.position, transform.right * 10, chocade);

        //Izquierda
        Physics.Raycast(transform.position, -transform.right, out izquierda, 10);
        Debug.DrawRay(transform.position, -transform.right * 10, chocaiz);

        //ArribaDerecha
        Physics.Raycast(transform.position, (transform.up - transform.right), out arribade, 10);
        Debug.DrawRay(transform.position, (transform.up - transform.right) * 10, chocaarde);

        //ArribaIzquierda
        Physics.Raycast(transform.position, (transform.up + transform.right), out arribaizq, 10);
        Debug.DrawRay(transform.position, (transform.up + transform.right) * 10, chocaariz);

        //AbajoDerecha
        Physics.Raycast(transform.position, (-transform.up - transform.right), out abajode, 10);
        Debug.DrawRay(transform.position, (-transform.up - transform.right) * 10, chocaabde);

        //AbajoIzquierda
        Physics.Raycast(transform.position, (-transform.up + transform.right), out abajoizq, 10);
        Debug.DrawRay(transform.position, (-transform.up + transform.right) * 10, chocaabiz);

        //enemy algorithm
        if (crono <= 0)
        {
            RandomizeObstacle(actualC);
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

    //Modifying obstacles
    public void RandomizeObstacle(GameObject randomized)
    {
        Xscale = Random.Range(0, 5);
        Yscale = Random.Range(0, 5);
        randomized.transform.localScale = new Vector2(Xscale, Yscale);
    }

    //Instantiate Obstacles
    void Createobstacles()
    {
        Instantiate(normalE, eSpawner[spawnerNum].position, Quaternion.Euler(0f, 0f, 0f));
        Instantiate(actualC, oSpawner[oSpawnerNum].position, transform.rotation);
    }
    
    public void HelpColor(Color tcolor, RaycastHit traycast, int tint)
    {
        if(traycast.collider)
        {
            tcolor = Color.blue;
        }
        if (traycast.collider == false)
        {
            tcolor = Color.red;
        }
    }
}