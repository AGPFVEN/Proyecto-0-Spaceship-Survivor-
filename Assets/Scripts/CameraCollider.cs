using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour
{
    public GameObject MCamera;
    
    void OnTriggerEnter2D(Collision2D col)
    {
        MCamera.GetComponent<CameraMovement>().Movement(false);
        Debug.Log("LOL");
    }
}
