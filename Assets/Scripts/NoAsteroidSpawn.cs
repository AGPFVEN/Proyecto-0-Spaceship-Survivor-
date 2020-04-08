using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAsteroidSpawn : MonoBehaviour
{
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

    private void Start()
    {
        randomnumbers = new float[2];
        randomnumber(randomnumbers);
    }
    private void FixedUpdate()
    {
        //Raycast con drawrays
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


        //funcion
        Doescollide(arriba, chocaar);
    }

    void Doescollide(RaycastHit voidhit, Color voidcolor)
    {
        if(voidhit.collider == false)
        {
            voidcolor = Color.green;
        }
        else
        {
            voidcolor = Color.red;
        }
    }
    void randomnumber(float[] randomizednumbers)
    {
        randomizednumbers = new float[2];
        randomizednumbers[0] = 1 + Random.Range(2, 5);
        randomizednumbers[1] = 1 + Random.Range(2, 5);

        if (randomnumbers[0] == 0)
        {
            randomnumbers[0] = 1 + Random.Range(2, 5);
        }

        if (randomnumbers[1] == 0)
        {
            randomnumbers[1] = 1 + Random.Range(2, 5);
        }
    }

    //Crear
    void Createobstacles(Transform place, GameObject original, float[] numers2scale)
    {
        GameObject copy = original;

        copy.transform.localScale = new Vector2(numers2scale[0] / 2, numers2scale[1] / 2);

        Instantiate(original, place.transform.position, Quaternion.Euler(0f, 0f, 0f));
    }
    void Createobstacles(Transform place, GameObject original)
    {
        int xscale = Random.Range(1, 5);
        int yscale = Random.Range(1, 5);

        GameObject copy = original;

        copy.transform.localScale = new Vector2(xscale, yscale);

        Instantiate(original, place.transform.position, Quaternion.Euler(0f, 0f, 0f));
    }
}