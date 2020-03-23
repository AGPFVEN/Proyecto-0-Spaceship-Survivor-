using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StarshipController : MonoBehaviour
{
    //Variables para disparar
    public float countDown;
    public float tocero;

    //Movement
    public float speed;
    public float tLimit;

    //Fire
    public GameObject Bullet;

    //HealthBar
    public Transform SpaceShip;
    public Transform healthBar;

    //Rotation
    Camera viewCamera;
    private Vector2 lookDirection;
    public Rigidbody2D rb;
    private float lookAngle;

    void start()
    {
        viewCamera = Camera.main;
        tocero = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        ////Movimiento 
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vInput * speed * Time.deltaTime * Time.deltaTime, 0);
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime * Time.deltaTime, 0, 0);

        //Aceleración
        if (tLimit > 0)
        {
            tLimit -= Time.deltaTime;
            tLimit -= Time.deltaTime;
            tLimit -= Time.deltaTime;
            speed = speed + 1 * Time.deltaTime;
        }

        //Rotation
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        //Fire
        if (Input.GetMouseButton(0) || Input.GetKeyDown("space"))
        {
            if (tocero <= 0)
            {
                FireBullet();
                tocero += countDown;
            }
        }
        if (tocero > 0)
        {
            tocero -= 1 * Time.deltaTime;
        }

        //Ability

    }

    //Disparo(función)
    public void FireBullet()
    {
        GameObject firedBullet = Instantiate(Bullet, SpaceShip.position, transform.rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = transform.up * 20f;
    }

    //Barra de Vida desactivada
    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    healthBar.GetComponent<HealthBar>().Damage(15f);
    //}
}