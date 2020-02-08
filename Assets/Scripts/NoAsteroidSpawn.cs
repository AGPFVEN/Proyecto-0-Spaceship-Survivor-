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
        Debug.DrawRay(transform.position, (transform.up - transform.right) * 10, Color.green);
        Debug.DrawRay(transform.position, (transform.up + transform.right) * 10, Color.green);
        Debug.DrawRay(transform.position, (-transform.up - transform.right) * 10, Color.green);
        Debug.DrawRay(transform.position, (-transform.up + transform.right) * 10, Color.green);
    }
}
