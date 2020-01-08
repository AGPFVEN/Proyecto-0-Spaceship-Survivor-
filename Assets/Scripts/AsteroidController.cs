using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float healthA;

    void Start()
    {
        healthA = 10f;
    }

    void FixedUpdate()
    {
        //Destruction of the asteroid in case of hit
        if (healthA <= 0)
        {
            Destruction();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "No Wall")
        {
            healthA--;

        }
        //if (collision.gameObject.name ==
    }

    void Destruction()
    {
        Destroy(gameObject);
    }
}
