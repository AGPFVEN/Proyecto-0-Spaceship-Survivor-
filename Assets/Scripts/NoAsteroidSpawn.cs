using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAsteroidSpawn : MonoBehaviour
{
    private void Start()
    {

    }
    private void FixedUpdate()
    {
        //if(Physics2D.Raycast(transform.position, transform.forward))
        //{
        //    Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
        //}
        //else
        //{
        //    Debug.DrawRay(transform.position, transform.forward * 10, Color.green);
        //}

        Debug.DrawRay(transform.position, transform.up * 10, Color.green);
        Debug.DrawRay(transform.position, -transform.up * 10, Color.green);
        Debug.DrawRay(transform.position, transform.right * 10, Color.green);
        Debug.DrawRay(transform.position, -transform.right * 10, Color.green);
        Debug.DrawRay(transform.position, (transform.up - transform.right) * 10, Color.blue);
        Debug.DrawRay(transform.position, (transform.up + transform.right) * 10, Color.green);
        Debug.DrawRay(transform.position, (-transform.up - transform.right) * 10, Color.green);
        Debug.DrawRay(transform.position, (-transform.up + transform.right) * 10, Color.green);

        //Raycast
        RaycastHit arriba, abajo, derecha, izquierda, arribade, arribaizq, abajode, abajoizq;
        Physics.Raycast(transform.position, transform.up, out arriba);
        Physics.Raycast(transform.position, -transform.up, out abajo);
        Physics.Raycast(transform.position, transform.right, out derecha);
        Physics.Raycast(transform.position, -transform.right, out izquierda);
        Physics.Raycast(transform.position, (transform.up - transform.right), out arribade);
        Physics.Raycast(transform.position, (transform.up + transform.right), out arribaizq);
        Physics.Raycast(transform.position, (-transform.up - transform.right), out abajode);
        Physics.Raycast(transform.position, (-transform.up + transform.right), out abajoizq);

    }
}
