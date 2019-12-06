using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesterMove : MonoBehaviour
{
    public Vector2 lookDirection;
    public float lookAngle;
    public float speed;
    public float tLimit;

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
    }
}
