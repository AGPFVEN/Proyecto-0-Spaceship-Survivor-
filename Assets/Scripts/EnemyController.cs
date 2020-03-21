using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //wall walking
    Color disparo;

    //bool colActivated;
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
    //float movementSpeed;

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
        //movementSpeed = 0;
        Target = GameObject.FindGameObjectWithTag("Player").transform;

        //raycast color 
        disparo = Color.cyan;
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

        //Movimiento

        if (distanceEP > customdistanceEP)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, 1.5f * Time.deltaTime);
        }

        //Disparo
        if (distanceEP <= customdistanceEP)
        {
            if (crono != cronoL)
            {
                if (crono >= cronoL)
                {

                    FiredBullet(Bullet);
                    crono = 0;

                }
                crono += 1 * Time.deltaTime;
            }
        }

        //Raycast
        RaycastHit enemyhit;

        if (changedone == false)
        {
            transform.position += new Vector3(0, 0, 10);
            changedone = true;
        }

        Physics.Raycast(transform.position, transform.forward, out enemyhit);

        //if (enemyhit.collider.gameObject.CompareTag("Player"))
        //{
        //    disparo = Color.black;
        //}
        //else
        //{
        //    disparo = Color.cyan;
        //}
        //Debug.DrawRay(transform.position, -Vector2.MoveTowards(transform.position, Target.position, 1 * Time.deltaTime));
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        {
            healthE--;
        }
    }

    //void FindVisibleTargets()
    //{
    //    Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, viewRadius, targetMask);
    //    for (int i = 0; i < targetsInViewRadius.Length; i++)
    //    {
    //        Transform target = targetsInViewRadius [i].transform;
    //    }
    //}
    void FiredBullet(GameObject bullet)
    {
        GameObject firedbullet =Instantiate(bullet, Barrel.position, transform.rotation);
        firedbullet.GetComponent<Rigidbody2D>().velocity = transform.up * 20f;

    }
}