using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitOfWall : MonoBehaviour
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

    //Distancias
    float vertical;
    float horizontal;
    public float diagonal;

    //Distancias para el raycast
    float rvertical;
    float rhorizontal;

    //Vectores Super Useful
    Vector3 ab;
    Vector3 di;

    // Start is called before the first frame update
    void Start()
    {
        Color chocaar = Color.blue;
        Color chocaab = Color.red;
        Color chocade = Color.red;
        Color chocaiz = Color.red;
        Color chocaarde = Color.red;
        Color chocaariz = Color.red;
        Color chocaabde = Color.red;
        Color chocaabiz = Color.red;

        //Vectores Useful
        ab = transform.up * transform.localScale.y * 5.4f;
        di = transform.right * transform.localScale.x * 9.6f;
    }

    // Update is called once per frame
    void Update()
    {

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////Raycast

        RaycastHit arriba, abajo, derecha, izquierda, arribade, arribaizq, abajode, abajoizq;

        //Arriba
        Physics.Raycast(transform.position, ab, out arriba);
        Debug.DrawRay(transform.position, ab* 2, chocaar);

        //Abajo
        Physics.Raycast(transform.position, -ab, out abajo);
        Debug.DrawRay(transform.position, -ab, chocaab);

        //Derecha
        Physics.Raycast(transform.position, di, out derecha);
        Debug.DrawRay(transform.position, di, chocade);

        //Izquierda
        Physics.Raycast(transform.position, -di, out izquierda);
        Debug.DrawRay(transform.position, -di, chocaiz);

        //ArribaDerecha
        Physics.Raycast(transform.position, (ab + di), out arribade);
        Debug.DrawRay(transform.position, (ab + di), chocaarde);

        //ArribaIzquierda
        Physics.Raycast(transform.position, (ab - di), out arribaizq, 10);
        Debug.DrawRay(transform.position, (ab - di), chocaariz);

        //AbajoDerecha
        Physics.Raycast(transform.position, (-ab + di), out abajode, 10);
        Debug.DrawRay(transform.position, (-ab +di), chocaabde);

        //AbajoIzquierda
        Physics.Raycast(transform.position, -(ab + di), out abajoizq, 10);
        Debug.DrawRay(transform.position,  -(ab + di), chocaabiz);
    }
}