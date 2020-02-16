using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnertest : MonoBehaviour
{
    public Transform place;
    public GameObject object2spawn;
    Color thechosencolor;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(object2spawn, place.position, transform.rotation);
        thechosencolor = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit testhit;
        Debug.DrawRay(transform.position, transform.up * 10, thechosencolor);
        Physics.Raycast(transform.position, transform.up, out testhit);

        //if (testhit.)
    }
}
