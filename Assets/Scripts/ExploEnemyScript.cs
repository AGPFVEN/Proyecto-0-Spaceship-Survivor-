using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploEnemyScript : MonoBehaviour
{
    //Movement
    Transform target;
    Rigidbody2D rb;
    Vector2 movevector;
    void Start()
    {
        //Movement Start
        target = GameObject.FindWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movevector = target.position-transform.position;
        rb.AddForce(movevector/2 , ForceMode2D.Force);
    }
}
