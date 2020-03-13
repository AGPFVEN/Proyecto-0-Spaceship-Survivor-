using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnertest : MonoBehaviour
{
    public Transform place;
    public GameObject object2spawno;

    Color thechosencolor;

    float crono;

    //modificar raycast
    float[] randomnumbers;

    // Start is called before the first frame update
    void Start()
    {
        Createobstacles(place, object2spawno);
        randomnumbers = new float[2];
        randomnumber(randomnumbers);

        //Starting crono
        crono = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //raycast collide
        RaycastHit testhit, Down, Right, Left;
        //Arriba
        Physics.Raycast(transform.position, transform.up, out testhit, randomnumbers[0] / 6);
        Debug.DrawRay(transform.position, transform.up * randomnumbers[0], thechosencolor);

        //Abajo
        Physics.Raycast(transform.position, -transform.up, out Down, randomnumbers[0]);
        Debug.DrawRay(transform.position, -transform.up * randomnumbers[0], thechosencolor);

        //Derecha
        Physics.Raycast(transform.position, transform.right, out Right, randomnumbers[1]);
        Debug.DrawRay(transform.position, transform.right * randomnumbers[1], thechosencolor);

        //Izquierda
        Physics.Raycast(transform.position, -transform.right, out Left, randomnumbers[1]);
        Debug.DrawRay(transform.position, -transform.right * randomnumbers[1], thechosencolor);

        if (testhit.collider == false && Down.collider == false && Right.collider == false && Left.collider == false )
        {
            thechosencolor = Color.red;
            //crono
            if (crono <= 0)
            {
                randomnumbers = new float[2];
                randomnumber(randomnumbers);
                Createobstacles(place, object2spawno, randomnumbers);
                crono = 5;
            }
        }
        else
        {
            thechosencolor = Color.green;
        }
        if (crono >= 0)
        {
            crono -= 1 * Time.deltaTime;
        }
    }

    void randomnumber(float[] randomizednumbers)
    {
        randomizednumbers = new float[2]; 
        randomizednumbers[0] = 1 + Random.Range(2, 5);
        randomizednumbers[1] = 1 + Random.Range(2, 5);

        if(randomnumbers[0] == 0)
        {
            randomnumbers[0] = 1 + Random.Range(2, 5);
        }

        if (randomnumbers[1] == 0)
        {
            randomnumbers[1] = 1 + Random.Range(2, 5);
        }
    }

    //Crear
    void Createobstacles(Transform place, GameObject original, float[] numers2scale)
    {
        GameObject copy = original;

        copy.transform.localScale = new Vector2(numers2scale[0]/2, numers2scale[1]/2);

        Instantiate(original, place.transform.position, Quaternion.Euler(0f, 0f, 0f));
    }
    void Createobstacles(Transform place, GameObject original)
    {
        int xscale = Random.Range(1, 5);
        int yscale = Random.Range(1, 5);

        GameObject copy = original;

        copy.transform.localScale = new Vector2(xscale, yscale);

        Instantiate(original, place.transform.position, Quaternion.Euler(0f, 0f, 0f));
    }
}