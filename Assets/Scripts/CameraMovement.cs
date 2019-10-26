using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform Target;
    public GameObject Player;
    public GameObject CameraCuadrado;
    public float movementSpeed;
    //Rigidbody2D rb;
    public Vector2 lookDirection;
    public float lookAngle;
    // Start is called before the first frame update
    void Start()
    {
        //this.rb.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    public void Movement (bool chocando)
    {
        if (chocando == true)
        {
            Debug.Log("LOL");
        } 
    }
}
