﻿using System.Collections;
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
    public float vertical;
    public float horizontal;
    public float diagonal;

    // Start is called before the first frame update
    void Start()
    {
        Color chocaar = Color.red;
        Color chocaab = Color.red;
        Color chocade = Color.red;
        Color chocaiz = Color.red;
        Color chocaarde = Color.red;
        Color chocaariz = Color.red;
        Color chocaabde = Color.red;
        Color chocaabiz = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit arriba, abajo, derecha, izquierda, arribade, arribaizq, abajode, abajoizq;

        //Arriba
        Physics.Raycast(transform.position, transform.up, out arriba, 10);
        Debug.DrawRay(transform.position, transform.up * (vertical * transform.localScale.y), chocaar);

        //Abajo
        Physics.Raycast(transform.position, -transform.up, out abajo, 10);
        Debug.DrawRay(transform.position, -transform.up * vertical, chocaab);

        //Derecha
        Physics.Raycast(transform.position, transform.right, out derecha, 10);
        Debug.DrawRay(transform.position, transform.right * horizontal, chocade);

        //Izquierda
        Physics.Raycast(transform.position, -transform.right, out izquierda, 10);
        Debug.DrawRay(transform.position, -transform.right * horizontal, chocaiz);

        //ArribaDerecha
        Physics.Raycast(transform.position, (transform.up - transform.right), out arribade, 10);
        Debug.DrawRay(transform.position, (transform.up - transform.right) * diagonal, chocaarde);

        //ArribaIzquierda
        Physics.Raycast(transform.position, (transform.up + transform.right), out arribaizq, 10);
        Debug.DrawRay(transform.position, (transform.up + transform.right) * diagonal, chocaariz);

        //AbajoDerecha
        Physics.Raycast(transform.position, (-transform.up - transform.right), out abajode, 10);
        Debug.DrawRay(transform.position, (-transform.up - transform.right) * diagonal, chocaabde);

        //AbajoIzquierda
        Physics.Raycast(transform.position, (-transform.up + transform.right), out abajoizq, 10);
        Debug.DrawRay(transform.position, (-transform.up + transform.right) * diagonal, chocaabiz);
    }
}
