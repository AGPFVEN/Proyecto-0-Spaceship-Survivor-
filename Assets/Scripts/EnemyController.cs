using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //wall walking
    bool colActivated;
    bool changedone;

    //fire
    public GameObject Bullet;
    public Transform Barrel;
    public float crono;
    public float cronoL;

    //Destroyable
    float healthE;

    //Rigidbody2D rigidbody;
    Camera viewcamera;
    
    //Shift
    float slowness;
    float movementSpeed;

    //Turn
    float lookAngle;
    Vector2 lookDirection;

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
        //Collider
        healthE = 1;
        changedone = false;

        //Cadencia
        customdistanceEP = 100;
        crono = 0;
        cronoL = 2;

        //rigidbody = GetComponent<Rigidbody2D> ();
        viewcamera = Camera.main;
        movementSpeed = 0;
        Target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if(healthE < 0)
        {
            Destroy(this);
        }

        ////Rotation to look Player
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        lookDirection = Target.position - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        ////Player detection
        distanceEP = Vector2.Distance(transform.position, Target.position - transform.position);
        if (distanceEP <= customdistanceEP)
        {
            if (crono != cronoL)
            {
                if (crono >= cronoL)
                {
                    if (colActivated == false)
                    {
                        FireBullet();
                        crono = 0;
                    }
                }
                crono += 1 * Time.deltaTime;
            }
        }

        //Movimiento
        if(!colActivated)
        {
            if (slowness <= 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.position, 1.5f * Time.deltaTime);
                Debug.DrawLine(transform.position, Target.position);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, Target.position, 1.5f * Time.deltaTime / slowness);
                Debug.DrawLine(transform.position, Target.position);
                slowness -= 1 * Time.deltaTime;
            }
        }

        //Colliders

        RaycastHit enemyhit;
        if (colActivated == true)
        {
            if (changedone == false)
            {
                transform.position += new Vector3(0, 0, 10);
                changedone = true;
            }

            //transform.position = Vector2.MoveTowards(transform.position + new Vector3(0, 0, 10), Target.position + new Vector3(0, 0, 10), 1 * Time.deltaTime);

            Physics.Raycast(transform.position, transform.forward, out enemyhit);
            Debug.DrawRay(transform.position, -Vector2.MoveTowards(transform.position, Target.position, 1 * Time.deltaTime) , Color.red);
            transform.position = Vector3.MoveTowards(transform.position, Target.position + new Vector3(0, 0, 10), 1 * Time.deltaTime);


            //Debug.DrawLine(transform.position, Target.position + new Vector3(0, 0, 10));
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            colActivated = true;
        }

        else
        {
            slowness++;
            healthE--;
        }
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