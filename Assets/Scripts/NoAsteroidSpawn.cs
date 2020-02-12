using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAsteroidSpawn : MonoBehaviour
{
    bool spawnallowed;
    bool sichocaar = true;
    bool sichocaab = true;
    bool sichocade = true;
    bool sichocaiz = true;
    bool sichocaarde = true;
    bool sichocaariz = true;
    bool sichocaabde = true;
    bool sichocaabiz = true;

    Color chocaar = Color.green;
    Color chocaab;
    Color chocade;
    Color chocaiz;
    Color chocaarde;
    Color chocaariz;
    Color chocaabde;
    Color chocaabiz;


    private void Start()
    {
        spawnallowed = false;
    }
    private void FixedUpdate()
    {
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

        //elrayazo(arriba, sichocaar);
        //elrayazo(abajo, sichocaab);
        //elrayazo(izquierda, sichocaiz);
        //elrayazo(derecha, sichocade);
        //elrayazo(arribade, sichocaarde);
        //elrayazo(arribaizq, sichocaariz);
        //elrayazo(abajode, sichocaabde);
        //elrayazo(abajoizq, sichocaabiz)

        //Colors
        elcolorazo(chocaar, sichocaar, arriba);
        //elcolorazo(chocaab, sichocaab);
        //elcolorazo(chocade, sichocade);
        //elcolorazo(chocaiz, sichocaiz);
        //elcolorazo(chocaarde, sichocaarde);
        //elcolorazo(chocaariz, sichocaariz);
        //elcolorazo(chocaabde, sichocaabde);
        //elcolorazo(chocaabiz, sichocaabiz);
    }

    void elcolorazo(Color elcolor, bool sichoca, RaycastHit elrayo)
    {
        if (elrayo.collider == true)
        {
            elcolor = Color.red;
        }
        else
        {
            elcolor = Color.green;
        }
    }

    //void elrayazo(RaycastHit elrayo, bool sichoca)
    //{
    //    if (elrayo.collider == true)
    //    {
    //        sichoca = false;
    //    }
    //    else
    //    {
    //        sichoca = true;
    //    }
    //}
}
