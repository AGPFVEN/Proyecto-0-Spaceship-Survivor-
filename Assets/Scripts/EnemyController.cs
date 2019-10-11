using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Transform Target;
    public GameObject Player;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 forwardAxis = new Vector3(0, 0, -1);

        transform.LookAt(Target.position, forwardAxis);
        Debug.DrawLine(transform.position, Target.position);
        transform.eulerAngles = new Vector3(0, 0, -transform.eulerAngles.z);
        transform.position -= transform.TransformDirection(Vector2.up) * movementSpeed;

        //Target = Player.transform;
        //Vector3 forwardAxis = new Vector3(0, 0, -1);

        //transform.LookAt(Target.position, Target.position);
        //Debug.DrawLine(transform.position, Target.position);
        //transform.eulerAngles = new Vector3(0, 0, Target.position.z);
        //transform.position -= transform.TransformDirection(Vector2.up) * movementSpeed;
    }
}
