using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAsteroidSpawn : MonoBehaviour
{
    bool spawnallowed;
    bool sichoca;
    Color chocaar= Color.green;
    Color chocaab = Color.green;
    Color chocade = Color.green;
    Color chocaiz= Color.green;
    Color chocaarde = Color.green;
    Color chocaariz = Color.green;
    Color chocaabde = Color.green;
    Color chocaabiz = Color.green;


    private void Start()
    {
        spawnallowed = false;
    }
    private void FixedUpdate()
    {
        //Colors
        elcolorazo(chocaar);
        elcolorazo(chocaab);
        elcolorazo(chocade);
        elcolorazo(chocaiz);
        elcolorazo(chocaarde);
        elcolorazo(chocaariz);
        elcolorazo(chocaabde);
        elcolorazo(chocaabiz);


        //Creando los drawrays
        Debug.DrawRay(transform.position, transform.up * 10, chocaar);
        Debug.DrawRay(transform.position, -transform.up * 10, chocaab);
        Debug.DrawRay(transform.position, transform.right * 10, chocade);
        Debug.DrawRay(transform.position, -transform.right * 10, chocaiz);
        Debug.DrawRay(transform.position, (transform.up - transform.right) * 10, chocaarde);
        Debug.DrawRay(transform.position, (transform.up + transform.right) * 10, chocaariz);
        Debug.DrawRay(transform.position, (-transform.up - transform.right) * 10, chocaabde);
        Debug.DrawRay(transform.position, (-transform.up + transform.right) * 10, chocaabiz);

        //Raycast
        RaycastHit arriba, abajo, derecha, izquierda, arribade, arribaizq, abajode, abajoizq;
        Physics.Raycast(transform.position, transform.up, out arriba, 10);
        Physics.Raycast(transform.position, -transform.up, out abajo, 10);
        Physics.Raycast(transform.position, transform.right, out derecha, 10);
        Physics.Raycast(transform.position, -transform.right, out izquierda, 10);
        Physics.Raycast(transform.position, (transform.up - transform.right), out arribade, 10);
        Physics.Raycast(transform.position, (transform.up + transform.right), out arribaizq, 10);
        Physics.Raycast(transform.position, (-transform.up - transform.right), out abajode, 10);
        Physics.Raycast(transform.position, (-transform.up + transform.right), out abajoizq, 10);

        elrayazo(arriba);
        elrayazo(abajo);
        elrayazo(izquierda);
        elrayazo(derecha);
        elrayazo(arribade);
        elrayazo(arribaizq);
        elrayazo(abajode);
        elrayazo(abajoizq);
    }

    void elcolorazo(Color elcolor)
    {
        if (sichoca == false)
        {
            elcolor = Color.red;
        }
        else
        {
            elcolor = Color.green;
        }
    }

    void elrayazo(RaycastHit elrayo)
    {
        if(elrayo.collider == true)
        {
            sichoca = false;
        }
        else
        {
            sichoca = true;
        }
    }
}
