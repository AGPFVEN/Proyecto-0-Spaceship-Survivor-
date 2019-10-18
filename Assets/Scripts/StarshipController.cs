using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarshipController : MonoBehaviour
{
    public float speed = 5f;
    public float tLimit = 60;
    public GameObject Bullet;
    public Transform SpaceShip;
    public Transform healthBar;
    public Rigidbody2D rb;

    private Vector2 lookDirection;
    private float lookAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ////Movimiento 
        float vInput = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);
        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0, 0);


        //Aceleración
        if (tLimit > 0)
        {
            tLimit -= Time.deltaTime;
            tLimit -= Time.deltaTime;
            tLimit -= Time.deltaTime;
            speed = speed + 1 * Time.deltaTime;
        }

        //Disparo

        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        if (Input.GetMouseButton(0))
        {
            InvokeRepeating("FireBullet", 0.05f, 1f);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("FireBullet");
        }
    }

    //Disparo(función)
    private void FireBullet()
    {
        GameObject firedBullet = Instantiate(Bullet, SpaceShip.position, SpaceShip.rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = SpaceShip.up * 20f;
    }

    //Barra de Vida
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            healthBar.GetComponent<HealthBar>().Damage(20f);
        }
    }
}
