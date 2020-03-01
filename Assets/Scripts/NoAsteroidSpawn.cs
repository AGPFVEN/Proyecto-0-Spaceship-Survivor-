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
        spawnallowed = false;
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
        //Doescollide(arriba, sichocaar, chocaar);
        if (arriba.collider == false)
        {
            chocaar = Color.red;
        }
        else
        {
            chocaar = Color.green;
        }

        //elrayazo(arriba, sichocaar);
        //elrayazo(abajo, sichocaab);
        //elrayazo(izquierda, sichocaiz);
        //elrayazo(derecha, sichocade);
        //elrayazo(arribade, sichocaarde);
        //elrayazo(arribaizq, sichocaariz);
        //elrayazo(abajode, sichocaabde);
        //elrayazo(abajoizq, sichocaabiz)

        //Colors
        //elcolorazo(chocaar, sichocaar, arriba);
        //elcolorazo(chocaab, sichocaab);
        //elcolorazo(chocade, sichocade);
        //elcolorazo(chocaiz, sichocaiz);
        //elcolorazo(chocaarde, sichocaarde);
        //elcolorazo(chocaariz, sichocaariz);
        //elcolorazo(chocaabde, sichocaabde);
        //elcolorazo(chocaabiz, sichocaabiz);

    }

    void Doescollide(RaycastHit voidhit, bool voidbool, Color voidcolor)
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

    //void elcolorazo(Color elcolor, bool sichoca, RaycastHit elrayo)
    //{
    //    if (elrayo.collider == true)
    //    {
    //        elcolor = Color.red;
    //        print("choca");
    //    }
    //    else
    //    {
    //        elcolor = Color.green;
    //    }
    //}

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
