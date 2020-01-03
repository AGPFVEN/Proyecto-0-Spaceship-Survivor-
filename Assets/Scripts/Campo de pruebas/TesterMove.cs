using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesterMove : MonoBehaviour
{
    public Vector2 lookDirection;
    public float lookAngle;

    //Player detection
    Transform Target;

    //Distance
    float distanceEP;
    float customdistanceEP = 5;

    //fire speedness
    float crono;
    float cronoL = 5;

    //fire
    public Transform Barrel;
    public GameObject Bullet;

    void Start()
    {
        crono = 0;
    }


    void FixedUpdate()
    {
        //Rotation to look Player
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.DrawLine(transform.position, Target.position);
        lookDirection = Target.position - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        //fire or move
        distanceEP = Vector2.Distance(transform.position, Target.position - transform.position);
        if (distanceEP <= customdistanceEP)
        {
            if (crono != cronoL)
            {
                crono += 1 * Time.deltaTime;
            }
            if (crono >= cronoL)
            {
                FireBullet();
                crono = 0;
            }
        }
    }

    public void FireBullet()
    {
        GameObject firedBullet = Instantiate(Bullet, Barrel.position, transform.rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = transform.up * 20f;
    }
}
