using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //fire
    public GameObject Bullet;
    public GameObject SpaceShip;
    public Transform Barrel;
    float crono;
    public float cronoL;


    //Destroyable
    public float healthE;

    //Rigidbody2D rigidbody;
    Camera viewcamera;
    
    //Shift
    public float movementSpeed;

    //Turn
    public float lookAngle;
    public Vector2 lookDirection;

    //Player detection
    Transform Target;
    public float viewRadius;
    public float viewAngle;
    public float distanceEP;
    public float customdistanceEP;
    public Vector3 DirFromAngle(float  angleInDegrees, bool angleIsGlobal)
    {
        if(!angleIsGlobal)
        {
            angleInDegrees += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }
    public LayerMask targetMask;
    public LayerMask obstacleMask;

    void start()
    {
        
        //Cadencia
        crono = 0;
        //rigidbody = GetComponent<Rigidbody2D> ();
        viewcamera = Camera.main;
    }

    void FixedUpdate()
    {
        //Destruction of the asteroid in case of hit
        if (healthE <= 0)
        {
            Destroy(gameObject);
        }

        //Rotation to look Player
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.DrawLine(transform.position, Target.position);
        lookDirection = Target.position - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        //Player detection
        distanceEP = Vector2.Distance(transform.position, Target.position - transform.position);
        if(distanceEP <= customdistanceEP)
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

        //Movimiento
        transform.position = Vector2.MoveTowards(transform.position, Target.position, movementSpeed * Time.deltaTime);
    }
    void FindVisibleTargets()
    {
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, viewRadius, targetMask);
        for (int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Transform target = targetsInViewRadius [i].transform;
        }
    }
    public void FireBullet()
    {
        GameObject firedBullet = Instantiate(Bullet, Barrel.position, transform.rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = transform.up * 20f;
    }
}