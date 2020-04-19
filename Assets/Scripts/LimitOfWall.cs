using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitOfWall : MonoBehaviour
{
    //Danger Wall
    public Sprite wallsprite;
    public Sprite dangersprite;
    SpriteRenderer wallrender;

    //Colores de los raycast
    Color chocaar;
    Color chocaab;
    Color chocade;
    Color chocaiz;
    Color chocaarde;
    Color chocaariz;
    Color chocaabde;
    Color chocaabiz;

    //Vectores Super Useful
    Vector3 ab;
    Vector3 di;

    //Variables for the raycasts module
    float xmodule;
    float ymodule;
    float xymodule;

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

        //Danger Wall
        wallrender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////Raycast

        RaycastHit arriba, abajo, derecha, izquierda, arribade, arribaizq, abajode, abajoizq;

        //Arriba
        Physics.Raycast(transform.position, ab, out arriba, ab.magnitude);
        Debug.DrawRay(transform.position, ab, Doesthecolorcollide(chocaar, arriba));

        //Abajo
        Physics.Raycast(transform.position, -ab, out abajo, ab.magnitude);
        Debug.DrawRay(transform.position, -ab, Doesthecolorcollide(chocaab, abajo));

        //Derecha
        Physics.Raycast(transform.position, di, out derecha, di.magnitude);
        Debug.DrawRay(transform.position, di, Doesthecolorcollide(chocade, derecha));

        //Izquierda
        Physics.Raycast(transform.position, -di, out izquierda, di.magnitude);
        Debug.DrawRay(transform.position, -di, Doesthecolorcollide(chocaiz, izquierda));

        //ArribaDerecha
        Physics.Raycast(transform.position, (ab + di), out arribade, (ab + di).magnitude);
        Debug.DrawRay(transform.position, (ab + di), Doesthecolorcollide(chocaarde, arribade));

        //ArribaIzquierda
        Physics.Raycast(transform.position, (ab - di), out arribaizq, (ab - di).magnitude);
        Debug.DrawRay(transform.position, (ab - di), Doesthecolorcollide(chocaariz, arribaizq));

        //AbajoDerecha
        Physics.Raycast(transform.position, (-ab + di), out abajode, (-ab + di).magnitude);
        Debug.DrawRay(transform.position, (-ab +di), Doesthecolorcollide(chocaabde, abajode));

        //AbajoIzquierda
        Physics.Raycast(transform.position, -(ab + di), out abajoizq, (ab + di).magnitude);
        Debug.DrawRay(transform.position,  -(ab + di), Doesthecolorcollide(chocaabiz, abajoizq));

        //Delete if it is surrounded
        if (arriba.collider && abajo.collider && derecha.collider && izquierda.collider && arribade.collider && arribaizq.collider && abajode.collider && abajoizq.collider)
        {
            Destroy(gameObject);
        }
    }

    static Color Doesthecolorcollide(Color acolor, RaycastHit aray)
    {
        if(aray.collider)
        {
            acolor = Color.green;
        }
        else
        {
            acolor = Color.red;
        }
        return acolor;
    }
    public void EnemyIsHere()
    {
        
    }
}