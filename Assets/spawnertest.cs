using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnertest : MonoBehaviour
{
    public Transform place;
    public GameObject object2spawno;

    Color thechosencolor;

    float crono;

    public bool ready2spawn;

    // Start is called before the first frame update
    void Start()
    {
        ready2spawn = true;
        Createobstacles(place, object2spawno);

        //Starting crono
        crono = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //method
        //ready2spawn = Ready2spawn;

        //raycast collide
        RaycastHit testhit;
        Physics.Raycast(transform.position, transform.up, out testhit, 10f);
        Debug.DrawRay(transform.position, transform.up * 10, thechosencolor);

        if (testhit.collider == false)
        {
            thechosencolor = Color.red;
            //crono
            if (crono <= 0 && ready2spawn == true)
            {
                Createobstacles(place, object2spawno);
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
        print(crono);
    }

    //Crear
    void Createobstacles(Transform place, GameObject original)
    {
        int xscale = Random.Range(1, 5);
        int yscale = Random.Range(1, 5);

        GameObject copy = original;

        copy.transform.localScale = new Vector2(xscale, yscale);
        
        Instantiate(original, place.transform.position, Quaternion.Euler(0f, 0f, 0f));
    }

    public bool Ready2spawn(bool condition)
    {
        if(condition == true)
        {
            return true;
        }

        if (condition == false)
        {
            return false;
        }

        else
        {
            return false;
        }
    }
}