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

    // Start is called before the first frame update
    void Start()
    {
        Color chocaar = Color.red;
        Color chocaab = Color.red;
        Color chocade = Color.red;
        Color chocaiz = Color.red;
        //Color chocaarde = Color.red;
        //Color chocaariz = Color.red;
        //Color chocaabde = Color.red;
        //Color chocaabiz = Color.red;

        //Variables to multiply with scale
        vertical = 5.4f;
        horizontal = 9.6f;
    }

    // Update is called once per frame
    void Update()
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////Raycast

        RaycastHit arriba, abajo, derecha, izquierda, arribade, arribaizq, abajode, abajoizq;

        //Arriba
        Physics.Raycast(transform.position, transform.up, out arriba, 10);
        Debug.DrawRay(transform.position, transform.up * (vertical * transform.localScale.y), chocaar);

        //Abajo
        Physics.Raycast(transform.position, -transform.up, out abajo, 10);
        Debug.DrawRay(transform.position, -transform.up * (vertical * transform.localScale.y), chocaab);

        //Derecha
        Physics.Raycast(transform.position, transform.right, out derecha, 10);
        Debug.DrawRay(transform.position, transform.right * (horizontal * transform.localScale.x), chocade);

        //Izquierda
        Physics.Raycast(transform.position, -transform.right, out izquierda, 10);
        Debug.DrawRay(transform.position, -transform.right * (horizontal * transform.localScale.x), chocaiz);

        //ArribaDerecha
        Physics.Raycast(transform.position, (transform.up - transform.right), out arribade, 10);
        Debug.DrawRay(transform.position, (transform.up - transform.right) * (horizontal * (transform.localScale.y - transform.localScale.x)), chocaarde);

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
