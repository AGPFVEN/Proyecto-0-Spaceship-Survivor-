using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;

   

    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, target.position.z -10f);
  
        transform.LookAt(target);
    }
}