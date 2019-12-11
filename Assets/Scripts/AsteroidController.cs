using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float health;

    void Start()
    {
      
    }

    void FixedUpdate()
    {
        print(health);
        if(health < 0 || health == 0)
        {
            Destroy(this);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        health -= 5;
    }
}
