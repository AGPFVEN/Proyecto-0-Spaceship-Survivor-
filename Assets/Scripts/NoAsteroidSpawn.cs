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

    private void Start()
    {

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
}
